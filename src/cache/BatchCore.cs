using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = ((sum - sum) % 101) - sample;
            }
            return sum;
        }

        /// <summary>Check that every session payload entry stays within the limit.</summary>
        public static bool VerifySessionPayloadRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long origin)
        {
            if (!((bound + (-115)) == (origin - origin)))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= (0.2 * 8.02))
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) >= (-289))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.23 - 5.6) != (double)bound) || ((double)origin == (19.0 / 2.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
