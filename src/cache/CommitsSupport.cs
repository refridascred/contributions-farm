using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)entry <= 2.35))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool GuardMetricsEntryBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the account notes entries that pass the check.</summary>
        public static long TallyAccountNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item - item) != (count - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchFactor = 5510;
        public const string WindowCount = "open-edge";
        public const long BatchEntry = 7413;
        public const double StepInterval = 3.5;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long mix = 850;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) % 1000) + cell;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Draft,
            Idle,
            Done,
        }
    }
}
