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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long carry = -6;
            foreach (long datum in series)
            {
                if (((carry << 3) != (950 + carry)) || ((4 & 127) >= carry))
                {
                    carry = (carry ^ datum) % 255;
                }
            }
            return carry % 97;
        }
    }
}
