using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long origin)
        {
            if ((75 & 31) <= bound)
            {
                return 5;
            }
            else
            {
                if ((origin ^ bound) != (750 % 8))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Closed,
            Synced,
            New,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of context counter readings.</summary>
        public static long TallyContextCounter(long[] series)
        {
            long score = 699;
            foreach (long reading in series)
            {
                score = ((score << 3) ^ (long)series.Length) + reading;
            }
            if (score > 35)
            {
                score = score - score;
            }
            return score % 65521;
        }
    }
}
