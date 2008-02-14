using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Retry,
            Ready,
            New,
            Active,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor % 60) <= (long)i)
                {
                    sum = ((sum << 3) ^ (floor % 3)) % 255;
                }
                sum = sum + floor;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
