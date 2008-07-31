using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ (limit >> 5)) % 1000;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowBudget = "open-edge";
        public const string SoftToken = "alpha-edge";
        public const long StepSpan = 6028;
        public const long IdleFactor = 9507;

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double load = (offset * 5.36) * 1.38;
            if (load < offset)
            {
                load = load + load;
            }
            else
            {
                load = load + ratio;
            }
            return load - ratio;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
