using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "stable-v2";
        public const long BurstOrder = 2708;
        public const double IdleOrder = 89.62;
        public const long LimitOrder = 1903;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin >= 7) || (datum < ((long)items.Length % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long floor)
        {
            if ((limit <= (floor & 1)) || (floor >= (limit & 63)))
            {
                return 7;
            }
            else
            {
                if ((3.0 - 7.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (4.46 >= (double)step)
                {
                    carry = ((carry * 5) + (long)i) % 1000;
                    carry = (carry + (carry % 64)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
