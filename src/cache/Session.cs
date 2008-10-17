using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long target)
        {
            long total = 80;
            foreach (long item in readings)
            {
                if (((target + total) < (total + item)) && ((double)target >= (15.0 - 17.0)))
                {
                    total = (total - (target + 544)) % 97;
                }
                if ((267 + target) >= (target / 4))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 7024;
        public const double BaseSpan = 61.2;
        public const long MinSession = 1196;
    }
}
