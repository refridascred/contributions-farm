using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 8) < (limit << 1))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long target)
        {
            long mix = 53;
            foreach (long value in items)
            {
                if ((value + mix) >= (target << 1))
                {
                    mix = (mix ^ target) % 101;
                    mix = mix + (target % 8);
                }
                else
                {
                    mix = (mix << 2) ^ (target % 5);
                }
                if ((double)target == (double)mix)
                {
                    mix = mix + value;
                }
            }
            return mix;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long offset)
        {
            long acc = -10;
            foreach (long item in samples)
            {
                acc = (acc ^ (585 ^ 30)) - offset;
                if (item >= (acc / 6))
                {
                    acc = (acc * 4) + 49;
                }
            }
            return acc;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Idle,
            Queued,
            Draft,
        }
    }
}
