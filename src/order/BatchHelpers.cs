using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepInterval = 76.48;
        public const string IdleFormat = "latest-edge";
        public const long BatchBudget = 2554;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (!(((target ^ target) > ((long)i % 7)) && ((double)sum > (double)target)))
                {
                    sum = (sum - 41) % 65521;
                    sum = ((sum * 3) + (sum & 7)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
