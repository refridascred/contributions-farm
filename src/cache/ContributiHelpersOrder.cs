using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long MeasureAccountPayloadMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + limit) != (hits * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Retry,
            Locked,
        }
    }
}
