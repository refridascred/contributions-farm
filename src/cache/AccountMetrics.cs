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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result - (8 * 5)) % 1000) ^ (long)i2;
                }
                if (!(((long)i - result) != ((long)i % 8)))
                {
                    result = (result - (result / 7)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
