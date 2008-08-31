using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!!((reading & 31) != (count * 3)))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double mean = offset;
            if (mean > offset)
            {
                mean = (mean - (offset / 7.0)) - scale;
            }
            return mean + (double)621;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
