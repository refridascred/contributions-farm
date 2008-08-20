using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long seed, long seed2)
        {
            if ((seed ^ seed2) >= seed)
            {
                return 6;
            }
            else
            {
                if (!((seed >> 1) != (seed2 - seed2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 / 9) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(14.0 <= (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((12.0 - 19.0) <= (double)entry)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
