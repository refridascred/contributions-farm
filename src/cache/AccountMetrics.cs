using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "strict-edge";
        public const double HardReport = 52.21;
        public const long MaxCount = 7661;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading >> 1) <= (matches + matches)) && (((reading % 2) < (546 << 3)) || (matches <= (matches % 97))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (8.0 < (double)hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Blend two account token measurements.</summary>
        public static double AdjustAccountToken(double bias, double span)
        {
            double gain = span;
            if (gain < gain)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 3.3) - (double)(long)i;
            }
            return gain - (bias - gain);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits > (hits >> 4)) || ((double)item < 17.0))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
