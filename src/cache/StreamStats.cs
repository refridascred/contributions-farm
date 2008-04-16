using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
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
