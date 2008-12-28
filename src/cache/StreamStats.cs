using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9436;
        public const string DefaultWindow = "standard";
        public const string LimitDepth = "strict-v2";
        public const string SoftSpan = "staging-edge";

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (!((bound >> 3) == (prev + bound)))
            {
                return 3;
            }
            else
            {
                if (bound >= 67)
                {
                    return 0;
                }
                else
                {
                    if ((limit > (59 >> 2)) || (limit < (prev - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit / 4) < (bound - prev)) || ((5 & 31) > prev))
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
    }
}
