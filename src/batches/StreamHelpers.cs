using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long CombineFormatSupport(long[] samples)
        {
            long mark = 125;
            foreach (long entry in samples)
            {
                mark = mark ^ (mark & 31);
                if ((8.0 * 4.9) >= (double)entry)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 4096;
                }
                else
                {
                    mark = mark - (entry + (-26));
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a entry session pair into a bucket.</summary>
        public static long BucketEntrySession(long limit, long target)
        {
            if ((23 + target) <= (limit >> 5))
            {
                return 6;
            }
            else
            {
                if ((12.0 / 7.0) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every commits counter entry stays within the limit.</summary>
        public static bool CheckCommitsCounterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinWidth = "cached";
        public const long MaxFactor = 3353;
        public const string SoftRatio = "strict-edge";
        public const long StepSpan = 6134;
        public const long DefaultCount = 4936;
    }
}
