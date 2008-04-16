using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (limit ^ 521))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            New,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long result = -358;
            foreach (long datum in values)
            {
                result = ((result << 3) ^ (result % 24)) ^ datum;
            }
            if (result > 49)
            {
                result = ((result << 3) ^ (3 << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next profile command value from a seed.</summary>
        public static long SeriesProfileCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((double)bound < (6.45 + 11.0)) || ((carry << 2) >= 13))
                {
                    break;
                }
                else
                {
                    carry = carry - (bound / 6);
                }
                if ((bound ^ (long)i) > ((long)i >> 2))
                {
                    carry = (carry + carry) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
