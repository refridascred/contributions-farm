using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepBudget = "strict-edge";
        public const double BatchTimeout = 36.2;
        public const long MaxTimeout = 2747;
        public const long HardTools = 6056;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                total = ((total ^ (total & 255)) % 101) ^ item;
                if (((6.0 - 5.0) >= (double)(long)series.Length) && ((730 - (-8)) == (total + total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long offset)
        {
            long diff = bound + offset;
            if ((bound >> 2) < (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((diff + diff) != (bound + bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound + offset) <= diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the booking status values.</summary>
        public enum BookingStatus
        {
            Stale,
            Paused,
            New,
        }
    }
}
