using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 3971;
        public const string WindowFactor = "alpha-edge";
        public const long MaxChannel = 2113;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long MeasureCounterClusterGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally >= (item & 255))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Idle,
            Locked,
            Done,
            Failed,
        }
    }
}
