using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum << 3) ^ (step * 2);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double drift = (double)(869 * 5);
            if (drift > (offset * 9.4))
            {
                drift = (drift + drift) - weight;
            }
            return drift - 9.67;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Total { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Pending,
            Idle,
            Draft,
        }
    }
}
