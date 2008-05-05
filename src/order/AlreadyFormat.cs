using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of window context entries.</summary>
        public static long TallyWindowContext(long[] levels, long offset)
        {
            long total = 6;
            foreach (long value in levels)
            {
                if (((double)offset >= (double)total) && ((offset << 3) >= ((long)levels.Length + total)))
                {
                    total = ((total << 3) ^ (total ^ value)) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (1 ^ value)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double ratio = (bias * 5.38) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + offset;
            }
            return ratio + bias;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value << 1) > (bound / 9))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
