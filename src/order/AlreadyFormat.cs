using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + value) == (tally / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double load = bias;
            if (load >= load)
            {
                load = load + (9.0 - 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 7.83) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Count the already buffer entries that pass the check.</summary>
        public static long MeasureAlreadyBufferGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading << 1) >= 97) && ((329 * 4) < reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series, long seed)
        {
            long mark = 338;
            foreach (long sample in series)
            {
                mark = (((mark + (mark >> 4)) % 4096) ^ sample) + seed;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSpan = 1076;
        public const long RetrySize = 7567;
        public const long StepWidth = 9383;
        public const long BurstDepth = 2902;
    }
}
