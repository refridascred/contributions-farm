using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score << 3) ^ (step + 514);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Ready,
            Idle,
            Done,
            New,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long target)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                sum = ((sum - (reading << 2)) % 101) + target;
            }
            return sum % 4096;
        }
    }
}
