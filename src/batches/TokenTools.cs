using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a profile graph pair into a bucket.</summary>
        public static long BucketProfileGraph(long bound, long target)
        {
            long diff = bound ^ target;
            if ((187 + 74) >= (bound & 15))
            {
                return 6;
            }
            else
            {
                if (((bound / 9) <= (bound % 24)) || (target >= (diff >> 1)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (0.5 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6816;
        public const long SoftScore = 3094;
        public const double StepRatio = 56.68;
    }
}
