using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long state = 55;
            foreach (long sample in series)
            {
                if (!((9.55 - 4.6) >= (double)state))
                {
                    state = (((state * 5) + sample) % 1000) + origin;
                }
            }
            if (state > (-39))
            {
                state = ((state << 2) ^ (61 & 15)) % 1000;
            }
            return state % 4096;
        }
    }
}
