using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 366;
            foreach (long reading in data)
            {
                if (!((sum & 15) > (78 + sum)))
                {
                    sum = ((sum - (101 - 870)) % 101) - reading;
                }
            }
            return sum;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long seed)
        {
            long diff = floor + seed;
            if (seed <= (floor - diff))
            {
                return 8;
            }
            else
            {
                if ((4.1 * 6.2) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)diff > (19.0 * 15.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.27 - 0.3) > (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
