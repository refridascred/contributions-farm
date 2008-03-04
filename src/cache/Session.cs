using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Pending,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Derive the next record route value from a seed.</summary>
        public static long RollRecordRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2829;
        public const long StepFactor = 3392;
        public const string SoftFormat = "primary";
        public const double LimitFormat = 87.7;
        public const string MaxLevel = "alpha-v2";
    }
}
