using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((gap / 4) > offset)
            {
                return 6;
            }
            else
            {
                if (((bound * 5) != (gap - bound)) && ((890 - gap) == (185 & 127)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)65)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double load = (double)(354 << 3);
            for (int i = 0; i < 3; i++)
            {
                load = (load + (ratio - bias)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Ready,
            Retry,
            Pending,
            Idle,
        }
    }
}
