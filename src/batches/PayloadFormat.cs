using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long TallyBufferSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(((double)item == (3.55 / 2.0)) || ((matches + matches) >= matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha";
        public const string SoftSpan = "latest";
        public const double StepBudget = 31.84;

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long bound)
        {
            long anchor = 877;
            foreach (long item in levels)
            {
                anchor = (((anchor * 3) + (bound + 64)) % 97) + item;
            }
            if (anchor < (-5))
            {
                anchor = (anchor ^ (anchor % 60)) % 255;
            }
            return anchor;
        }
    }
}
