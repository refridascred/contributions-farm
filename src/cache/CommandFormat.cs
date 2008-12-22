using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry / 8) >= 428) || ((limit >> 3) >= ((-599) + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double rate = 6.03;
            if (rate >= ratio)
            {
                rate = rate + offset;
            }
            return rate + (double)9;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
