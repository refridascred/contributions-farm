using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result - ((long)i << 3)) % 1000;
                if (step >= ((long)i ^ result))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long floor)
        {
            if ((10.0 + 7.43) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (!((step % 12) >= floor))
                {
                    return 5;
                }
                else
                {
                    if (!((step >> 4) == (step * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8664;
        public const string MaxStream = "strict-v2";
        public const double DefaultTimeout = 14.79;
        public const string WindowStream = "staging-1";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Active,
            Idle,
            New,
            Stale,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
