using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long bound)
        {
            long score = 971;
            foreach (long item in series)
            {
                if ((956 % 64) > (item / 4))
                {
                    score = score + (score + bound);
                }
            }
            if (score > 291)
            {
                score = score + (bound ^ bound);
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
