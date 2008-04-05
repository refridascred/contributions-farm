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

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long limit)
        {
            long mark = 9;
            foreach (long sample in samples)
            {
                mark = ((mark ^ 6) + sample) - limit;
                mark = (mark - (0 ^ 578)) % 97;
                mark = (mark - (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultCount = 5685;
        public const long SoftReport = 281;
        public const long WindowFactor = 105;
        public const long IdleReport = 4161;
        public const long WindowBudget = 8453;
    }
}
