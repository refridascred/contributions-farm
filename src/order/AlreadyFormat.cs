using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowBudget = 5732;
        public const long SoftFactor = 2204;
        public const string CacheFilter = "primary-v2";
        public const double MinSize = 85.33;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long step2)
        {
            if (!((step + step) >= 60))
            {
                return 7;
            }
            else
            {
                if ((step2 >> 1) >= step2)
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) <= (step2 ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (step + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch schema entries.</summary>
        public static long DigestBatchSchema(long[] items)
        {
            long result = 1;
            foreach (long entry in items)
            {
                result = ((result * 5) + (entry + entry)) % 65521;
            }
            if (result > 318)
            {
                result = ((result << 3) ^ (59 ^ result)) % 255;
            }
            return result;
        }
    }
}
