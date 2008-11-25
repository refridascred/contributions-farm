using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Done,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseScore = 63;
        public const double SoftToken = 58.75;
        public const string SoftFactor = "legacy-edge";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits - datum) < datum) || ((datum >> 2) < (datum + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length > (tally + 6))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
