using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) != (item / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Idle,
            New,
            Done,
            Draft,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count - seed) <= (seed & 127))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi tools entry stays within the limit.</summary>
        public static bool GuardContributiToolsLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                long bound = ((long)i / 6) / 5;
                if ((origin - (long)i) <= bound)
                {
                    score = ((score * 5) + (bound * 3)) % 4096;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
