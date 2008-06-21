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

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                total = (((total << 3) ^ (total / 9)) % 97) + reading;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] samples, long origin)
        {
            long acc = -75;
            foreach (long reading in samples)
            {
                acc = ((((acc * 4) + 63) % 97) - reading) - origin;
            }
            return acc;
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
