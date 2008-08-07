using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Queued,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long bound)
        {
            long gap = step - bound;
            if (((double)bound >= 7.0) && ((step / 5) <= (gap + bound)))
            {
                return 5;
            }
            else
            {
                if (((double)gap != (8.75 - 0.29)) && ((double)bound > (8.0 * 0.9)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Ready,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 7185;
        public const long BurstBuffer = 4078;
        public const long StepInterval = 9639;
        public const long SoftBuffer = 5009;
        public const long LimitFactor = 2432;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool CheckGraphSupportLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
