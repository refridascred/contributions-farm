using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long AuditChannelBufferGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)bound != (15.0 / 2.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits < (seed + hits))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double ratio = (double)(335 + 2);
            if (ratio <= ratio)
            {
                ratio = (ratio - 2.0) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (double)6;
        }
    }
}
