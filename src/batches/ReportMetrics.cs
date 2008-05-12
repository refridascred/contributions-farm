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

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - (long)i;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
