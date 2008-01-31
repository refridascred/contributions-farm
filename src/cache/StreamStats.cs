using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry * 3) + (carry << 1);
                carry = (carry + (carry & 127)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen << 2) >= (cell << 3))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long limit2)
        {
            long offset = limit ^ limit2;
            if ((double)offset < 8.6)
            {
                return 7;
            }
            else
            {
                if ((limit - offset) > (offset / 7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
