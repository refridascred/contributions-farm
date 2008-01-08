using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples, long step)
        {
            long sum = 31;
            foreach (long value in samples)
            {
                sum = ((sum * 5) + (68 + value)) % 1000;
                if (!(sum <= (value & 3)))
                {
                    sum = (sum << 2) ^ (step & 127);
                }
                else
                {
                    sum = (sum * 3) + (22 + step);
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 3) ^ (step / 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long bound)
        {
            if (((bound ^ step) > bound) && ((double)bound >= (9.5 - 5.97)))
            {
                return 1;
            }
            else
            {
                if ((step > (bound % 7)) || ((7 * 3) <= (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound >= (step + bound)) && (step >= (step / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound << 1) == (7 + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
