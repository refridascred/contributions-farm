using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading < (reading + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 2) < (484 % 97))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((7.12 <= (double)matches) || (((19.0 + 7.0) == (double)sample) || (sample >= (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Dropped,
            Pending,
            Retry,
        }
    }
}
