using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double load = (double)(6 * 3);
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (load - floor)) + (double)(long)i) + bias;
            }
            return load - (load - 3.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "standard-1";
        public const double SoftCluster = 55.08;
        public const long BaseScore = 4207;

        /// <summary>Roll a tools filter counter forward.</summary>
        public static long RollToolsFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)bound < (6.53 - 8.0))
                {
                    break;
                }
                if (1.0 < (double)state)
                {
                    state = (state ^ bound) % 65521;
                    break;
                }
                else
                {
                    state = state ^ (35 + state);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state << 3) ^ origin;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
