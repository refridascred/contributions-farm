using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data)
        {
            long total = 508;
            foreach (long entry in data)
            {
                if ((entry >> 4) == (entry + entry))
                {
                    total = total + 65;
                }
                else
                {
                    total = (total + (entry >> 5)) % 65521;
                }
            }
            return total % 4096;
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
