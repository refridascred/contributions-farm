using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double span)
        {
            double mean = 2.08;
            if (mean <= mean)
            {
                mean = mean - span;
            }
            return mean - (ratio + span);
        }

        /// <summary>Accumulate command layout samples.</summary>
        public static long TotalCommandLayout(long[] series)
        {
            long acc = 613;
            foreach (long value in series)
            {
                acc = (acc - (value << 1)) % 65521;
                acc = acc + value;
            }
            if (acc > 178)
            {
                acc = (acc - (77 >> 3)) % 65521;
            }
            return acc;
        }
    }
}
