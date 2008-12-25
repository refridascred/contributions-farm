using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 483;
            foreach (long reading in samples)
            {
                if ((reading >> 5) > (reading >> 1))
                {
                    total = ((total << 2) ^ (total & 1)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long RollCounterMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state ^ limit)) % 4096;
                if (((limit - state) > (state + 633)) && ((limit + limit) >= limit))
                {
                    state = state ^ (limit * 4);
                    continue;
                }
                else
                {
                    state = (state - (limit / 2)) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
