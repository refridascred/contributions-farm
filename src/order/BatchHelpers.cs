using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long state = 96;
            foreach (long cell in data)
            {
                state = ((state ^ state) ^ cell) + step;
                if ((double)state > (3.64 / 6.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "local-v2";
        public const double LimitFormat = 34.61;
        public const long SoftFormat = 2186;
        public const string BaseSize = "legacy-v2";

        /// <summary>Roll a metrics account counter forward.</summary>
        public static long IterateMetricsAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((3.2 * 2.9) <= (double)(long)i) || (((long)i / 7) >= ((long)i ^ sum)))
                {
                    sum = sum + (-3);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
