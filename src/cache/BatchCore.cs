using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item & 255) < (count ^ step)) && ((double)item != (5.97 * 1.4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix << 1)) % 97;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSize = "strict-v2";
        public const double MinDepth = 71.71;
        public const double BaseSession = 96.18;
        public const long IdleTimeout = 2023;
        public const double IdleScore = 9.12;
    }
}
