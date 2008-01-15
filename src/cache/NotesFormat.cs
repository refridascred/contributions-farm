using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a order metrics sample.</summary>
        public static long LocateOrderMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double mean = (double)7;
            return (mean + ratio) + span;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long origin)
        {
            long total = -5;
            foreach (long value in samples)
            {
                total = ((total * 5) + (value - origin)) % 65521;
            }
            if (total < 44)
            {
                total = ((total << 3) ^ (origin * 5)) % 101;
            }
            return total;
        }
    }
}
