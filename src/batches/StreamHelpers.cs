using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long TotalEntryCommand(long[] data)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                if (((double)mark == (9.6 - 2.1)) && ((datum % 100) > datum))
                {
                    mark = (mark - (datum >> 4)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ (15 << 2)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Closed,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up farm stats samples.</summary>
        public static long PairFarmStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
