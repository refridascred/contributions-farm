using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long IterateContributiFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                double scale = (double)result / 8.0;
                result = result ^ (2 % 16);
                if (scale <= (scale / 7.0))
                {
                    scale = scale - (scale * 12.0);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                long slot = state;
                if ((slot + 687) > (slot * 4))
                {
                    state = (state * 2) + ((long)i >> 5);
                    state = ((state << 2) ^ (state % 3)) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
