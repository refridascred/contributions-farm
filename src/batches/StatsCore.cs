using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Failed,
            Pending,
            New,
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long TallyFilterChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits + hits) >= 764) && ((item - hits) != (6 + hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if (((double)(long)i <= (6.9 - 3.0)) || ((state >> 4) != (696 + 5)))
                {
                    state = (state << 3) ^ (66 & 1);
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
