using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first route token entry that matches the target.</summary>
        public static long FindRouteTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command already readings.</summary>
        public static long MatchCommandAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Dropped,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + state) >= state)
                {
                    state = (state ^ 58) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
