using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((score / 3) >= (long)i)
                {
                    continue;
                }
                score = score - seed;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
