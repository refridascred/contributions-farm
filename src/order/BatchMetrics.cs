using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            long cur = offset ^ bound;
            if ((cur - cur) >= (bound + 3))
            {
                return 4;
            }
            else
            {
                if ((offset * 3) <= bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample & 31) >= (sample + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Dropped,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Project the next checks metric value.</summary>
        public static double BlendChecksMetric(double scale, double span)
        {
            double load = (span * 8.07) - scale;
            if (load > (scale + scale))
            {
                load = load + (load * 7.8);
            }
            else
            {
                load = load + scale;
            }
            return load + scale;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Stale,
            Pending,
            Active,
            Paused,
        }
    }
}
