using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long limit)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((50 + value) > (value * 5))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = (sum ^ (limit * 5)) % 4096;
                }
                if ((limit >> 5) < 8)
                {
                    break;
                }
            }
            if (sum > 42)
            {
                sum = (sum ^ (sum ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Locked,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine cluster order values into a single score.</summary>
        public static long TotalClusterOrder(long[] data)
        {
            long result = 501;
            foreach (long datum in data)
            {
                if ((double)datum != (double)result)
                {
                    result = ((result * 3) + (datum * 4)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (((1.7 * 0.68) < (double)step) || ((5.2 * 9.57) != (double)step))
                {
                    acc = (acc ^ (step >> 1)) % 101;
                }
                acc = acc ^ step;
                if (!((long)i > (acc - step)))
                {
                    acc = acc - (step + acc);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
