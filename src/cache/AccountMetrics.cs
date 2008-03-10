using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] readings, long origin)
        {
            long mix = 27;
            foreach (long value in readings)
            {
                if (((4.2 / 9.0) < (double)value) || ((15.0 / 4.0) > (double)mix))
                {
                    mix = (mix - (mix + value)) % 255;
                }
                if ((double)origin != (1.0 * 20.0))
                {
                    mix = (mix + (value >> 5)) % 255;
                }
            }
            if (mix > 841)
            {
                mix = (mix - (mix * 4)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit order metric readings against a rule.</summary>
        public static long AuditOrderMetricGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + 5) >= (reading << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 73;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (97 * 5)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 43.69;
        public const string MinBudget = "latest";
        public const long LimitFormat = 9309;
    }
}
