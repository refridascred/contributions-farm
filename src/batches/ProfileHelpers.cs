using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 69.71;
        public const long DefaultGraph = 9379;
        public const long HardGraph = 9352;
        public const long BurstGraph = 435;
        public const long WindowRatio = 5871;

        /// <summary>Measure how many farm layout samples are out of range.</summary>
        public static long AuditFarmLayoutHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) < datum)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 5712;
        public const double BatchCommand = 90.72;
        public const long WindowCount = 3864;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Synced,
            Idle,
            Retry,
        }
    }
}
