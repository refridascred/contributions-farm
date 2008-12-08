using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha";
        public const long WindowSchema = 8311;
        public const long HardRatio = 8725;
        public const double LimitWidth = 52.81;

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long StepClusterFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor < (long)i) && (step > (anchor % 97)))
                {
                    anchor = (anchor + (anchor * 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                    anchor = (anchor ^ anchor) % 101;
                }
                if (((long)i < step) || ((step % 10) != (anchor & 1)))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3.08 + 7.1) < (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
