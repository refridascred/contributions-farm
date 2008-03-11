using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every report profile entry stays within the limit.</summary>
        public static bool ValidateReportProfileBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples, long step)
        {
            long state = 22;
            foreach (long datum in samples)
            {
                state = (state ^ (step - state)) % 101;
                if ((datum << 2) == (step + state))
                {
                    state = state ^ (state - datum);
                }
            }
            return state;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
