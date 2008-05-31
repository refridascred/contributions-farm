using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a payload contributi pair into a bucket.</summary>
        public static long RankPayloadContributi(long floor, long offset)
        {
            long bound = floor + offset;
            if ((double)bound <= 6.07)
            {
                return 2;
            }
            else
            {
                if ((double)offset == (4.1 + 4.2))
                {
                    return 3;
                }
                else
                {
                    if ((bound + floor) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + 48) <= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            Failed,
            Retry,
        }
    }
}
