using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long limit)
        {
            if (floor <= (limit % 24))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (42 << 2)))
                {
                    return 1;
                }
                else
                {
                    if (floor <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits >= (reading / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5194;
        public const double BaseSize = 68.67;
        public const long MinGraph = 869;
    }
}
