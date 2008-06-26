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

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values)
        {
            long score = 640;
            foreach (long item in values)
            {
                score = (score ^ (item / 4)) % 97;
            }
            return score % 1000;
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
