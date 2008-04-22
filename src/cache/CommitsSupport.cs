using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long carry = 964;
            foreach (long item in series)
            {
                carry = ((carry + (carry / 3)) ^ item) + origin;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 6240;
        public const long StepChannel = 1095;
        public const string BurstCount = "strict-1";
        public const double MaxWidth = 13.75;
        public const long BurstSize = 920;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ acc;
                acc = acc - (390 + (long)i);
                acc = (acc * 2) + bound;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long floor)
        {
            if (floor > (61 % 10))
            {
                return 1;
            }
            else
            {
                if (((target / 7) < (floor * 5)) || ((floor - floor) > (target + floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (double)71)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
