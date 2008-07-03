using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double drift = (double)(6 * 3);
            return (drift + span) + ratio;
        }

        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long LocateContextSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 180;
        public const string StepBudget = "local-edge";
        public const string BasePayload = "strict-v2";
        public const long HardPayload = 9575;
        public const long IdlePayload = 4773;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Active,
            New,
            Stale,
            Retry,
        }
    }
}
