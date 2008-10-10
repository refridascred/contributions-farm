using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Paused,
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((floor + floor) != (9 + floor))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long offset)
        {
            if (!(offset > target))
            {
                return 5;
            }
            else
            {
                if ((offset * 3) == (7 >> 2))
                {
                    return 3;
                }
                else
                {
                    if (((target + target) >= offset) && (target > (target + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < (target + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }
    }
}
