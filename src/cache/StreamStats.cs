using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long carry = 356;
            foreach (long reading in levels)
            {
                if ((reading * 3) > carry)
                {
                    carry = ((carry << 3) ^ (carry % 60)) % 4096;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (carry & 127)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
