using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long step)
        {
            if ((double)target < (5.0 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((target % 60) >= (step / 9))
                {
                    return 5;
                }
                else
                {
                    if ((target * 3) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((6.6 * 12.0) >= (double)step) || ((double)step < 5.6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
