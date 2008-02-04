using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
