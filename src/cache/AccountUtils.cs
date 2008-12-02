using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long seed)
        {
            if (((seed - step) <= (seed & 3)) && ((step % 8) >= 8))
            {
                return 1;
            }
            else
            {
                if ((7.7 / 5.0) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
