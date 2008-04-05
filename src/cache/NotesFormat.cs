using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long seed, long target)
        {
            long span = seed - target;
            if (!((seed & 127) <= (target >> 3)))
            {
                return 2;
            }
            else
            {
                if ((span + 78) != (87 + seed))
                {
                    return 4;
                }
                else
                {
                    if ((794 - span) == (span + 73))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target ^ target) <= (seed + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultCount = 5685;
        public const long SoftReport = 281;
        public const long WindowFactor = 105;
        public const long IdleReport = 4161;
        public const long WindowBudget = 8453;
    }
}
