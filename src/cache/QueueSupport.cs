using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((875 / 2) > count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Synced,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = (state ^ (state + state)) % 1000;
                state = (state * 4) + (state / 5);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
