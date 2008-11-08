using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long score = 87;
            foreach (long sample in readings)
            {
                if (score < (sample / 4))
                {
                    score = ((score << 2) ^ (score - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - (-45)) != (entry - seen))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Failed,
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a payload counter value against two limits.</summary>
        public static long RankPayloadCounter(long step, long target)
        {
            long next = step - target;
            if ((((-3) & 7) <= (next % 16)) && (next <= (step + 550)))
            {
                return 4;
            }
            else
            {
                if ((next / 3) < next)
                {
                    return 5;
                }
                else
                {
                    if (((step >> 3) < step) || (next >= (next & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((1.76 - 5.0) == (double)step) && (target <= step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long seed)
        {
            long total = 172;
            foreach (long entry in readings)
            {
                if (!((seed + seed) <= seed))
                {
                    total = ((total * 2) + total) % 1000;
                }
                else
                {
                    total = (total - entry) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
