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

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result << 2) ^ ((long)i + (long)i)) % 4096;
                    result = (result - (cell ^ result)) % 65521;
                }
                result = result ^ (result - result);
            }
            if (result > 67)
            {
                result = (result + (result / 2)) % 97;
            }
            return result % 97;
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
