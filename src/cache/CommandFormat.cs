using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (gain * 3.59)) + (double)(long)i) - rate;
            }
            return gain - bias;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool CheckPayloadFormatRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
