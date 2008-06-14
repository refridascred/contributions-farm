using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((9 & 3) != (bound % 12))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) < 48)
                {
                    return 7;
                }
                else
                {
                    if (bound < ((-618) & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if (2 < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer notes readings.</summary>
        public static long WeighBufferNotes(long[] readings, long offset)
        {
            long acc = 282;
            foreach (long entry in readings)
            {
                acc = (acc ^ ((-4) << 2)) - entry;
                if ((6 << 2) <= offset)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long floor)
        {
            if (((origin * 5) <= floor) && ((7.25 / 7.0) > (double)floor))
            {
                return 8;
            }
            else
            {
                if ((floor & 63) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long score = 80;
            foreach (long value in items)
            {
                score = (((score ^ (87 - score)) % 101) ^ value) + target;
            }
            return score;
        }
    }
}
