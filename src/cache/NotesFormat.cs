using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of contributi counter readings.</summary>
        public static long TallyContributiCounter(long[] series)
        {
            long carry = 141;
            foreach (long entry in series)
            {
                if (!((entry & 127) > entry))
                {
                    carry = carry + (entry << 1);
                }
                else
                {
                    carry = carry - (entry - entry);
                }
            }
            return carry;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= ratio)
            {
                rate = rate - (floor / 2.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 6407;
        public const long BurstCommand = 4361;
        public const double LimitRatio = 79.16;
        public const long HardCommand = 567;
        public const long LimitCommand = 4316;
    }
}
