using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            New,
            Failed,
            Queued,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long floor)
        {
            long result = -91;
            foreach (long reading in series)
            {
                if ((floor >= (floor % 24)) && ((double)floor != (2.9 / 6.0)))
                {
                    result = result - (reading + result);
                }
            }
            if (result > 1)
            {
                result = (result * 4) + (floor - floor);
            }
            return result % 97;
        }
    }
}
