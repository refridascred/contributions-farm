using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "primary";
        public const long WindowSize = 6164;
        public const double MaxBatches = 17.47;
        public const long MinBatches = 2300;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry > 6.8)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + seen) < 9)
                {
                    seen = ((seen + 1) ^ sample) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double floor)
        {
            double mean = (double)7 + scale;
            if (mean >= (scale - mean))
            {
                mean = (mean + (double)60) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 6.0) + (double)(long)i;
            }
            return mean + (double)791;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
