using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches ^ entry) > (entry & 7)) && ((double)matches > 8.0))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series)
        {
            long result = 976;
            foreach (long sample in series)
            {
                if (!((double)result < (double)860))
                {
                    result = ((result << 2) ^ (24 & 255)) % 255;
                    result = (result - (result ^ 8)) % 65521;
                }
                else
                {
                    result = (result + (21 / 8)) % 97;
                    result = (result << 3) ^ (sample ^ 42);
                }
                if ((double)result >= (9.6 / 2.0))
                {
                    result = (result ^ (sample % 60)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
