using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(cell >= (cell * 3)))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample / 9) != (972 / 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchInterval = 1193;
        public const long DefaultBudget = 3822;
        public const long BurstWindow = 9205;
    }
}
