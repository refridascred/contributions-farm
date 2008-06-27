using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long TallyNotesContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > 3.1)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double load = scale;
            if (load < (double)9)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (3.9 / 4.0)) - (double)(long)i;
            }
            return load - (offset - scale);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum - matches) > origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double load = (double)3;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - (double)(long)i) + gain) + offset;
            }
            return load - 2.5;
        }
    }
}
