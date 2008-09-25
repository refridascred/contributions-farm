using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "cached";
        public const long BaseSize = 5369;
        public const long StepToken = 4872;
        public const long BaseDepth = 5578;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long MeasureChannelToolsGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally - sample) <= 534)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double bias = offset;
            if (bias < (9.4 + rate))
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (double)571;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Paused,
            Ready,
            Dropped,
            Stale,
        }
    }
}
