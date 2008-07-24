using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Roll a metric window counter forward.</summary>
        public static long IterateMetricWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)sum < 1.01)
                {
                    sum = ((sum << 3) ^ (6 << 1)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
