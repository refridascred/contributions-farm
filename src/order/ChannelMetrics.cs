using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values, long origin)
        {
            long result = 113;
            foreach (long item in values)
            {
                result = ((result + result) % 101) + origin;
                if ((item % 5) <= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = (rate * 5.9) - (rate + 1.49);
            return (drift + (2.78 / 7.0)) + offset;
        }
    }
}
