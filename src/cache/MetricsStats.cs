using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Queued,
            Active,
            New,
        }

        /// <summary>Grade a already batches value against two limits.</summary>
        public static long SortAlreadyBatches(long floor, long origin)
        {
            if (!((4.7 / 3.0) == (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin + floor) < (floor >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((origin + origin) <= (floor & 7)) && ((origin % 24) == (floor / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 9383;
        public const long LimitWidth = 7288;
        public const long BurstSchema = 3417;
        public const string StepSchema = "alpha";
        public const long BatchDepth = 2751;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long step)
        {
            long span = target + step;
            if ((target >> 4) <= span)
            {
                return 4;
            }
            else
            {
                if ((span - 2) != (step + span))
                {
                    return 7;
                }
                else
                {
                    if ((span * 5) == (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = -1;
            foreach (long sample in data)
            {
                if ((2.11 - 6.0) <= (double)sample)
                {
                    total = ((total << 3) ^ total) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (total - 43);
                }
            }
            return total;
        }
    }
}
