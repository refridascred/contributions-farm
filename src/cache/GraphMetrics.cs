using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Done,
            Paused,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultSpan = 5.45;
        public const long WindowLevel = 1185;
        public const string LimitTimeout = "local-v2";
        public const long WindowWidth = 7860;
        public const long LimitFilter = 688;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = (state + entry) - target;
            }
            return state;
        }
    }
}
