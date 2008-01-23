using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseTimeout = 1791;
        public const string DefaultDepth = "fallback-1";
        public const double MaxRatio = 75.78;
        public const string MaxBudget = "standard-edge";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Failed,
            Closed,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally ^ tally) > item))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen >= (reading + (-131))) || !(251 >= reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics queue readings against a bound.</summary>
        public static bool GuardMetricsQueueBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
