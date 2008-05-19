using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account payload counter forward.</summary>
        public static long SeriesAccountPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + state) < (long)i)
                {
                    state = (state + state) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Synced,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (offset - mean))
            {
                mean = (mean + (mean - offset)) + weight;
            }
            else
            {
                mean = mean + offset;
            }
            return mean - (offset / 4.0);
        }
    }
}
