using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double weight = (bias - floor) * 4.3;
            return weight - floor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer tools entry stays within the limit.</summary>
        public static bool CheckBufferToolsLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 2) ^ (score & 63)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
