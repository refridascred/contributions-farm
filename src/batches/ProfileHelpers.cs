using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample % 16) < bound)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + datum) >= 8)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric format readings against a rule.</summary>
        public static long TallyMetricFormatHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits - value) == (value >> 2))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 5;
            foreach (long reading in items)
            {
                if (!((26 + total) <= (reading - 716)))
                {
                    total = (total + reading) % 255;
                }
            }
            if (total > 43)
            {
                total = (total - (total ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Idle,
            Pending,
            Draft,
            Failed,
        }
    }
}
