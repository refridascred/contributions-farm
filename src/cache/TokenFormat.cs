using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits * 5) > (origin * 2))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long carry = 831;
            foreach (long item in items)
            {
                if ((item * 3) > (target + carry))
                {
                    carry = (carry - (carry + item)) % 97;
                }
            }
            if (carry < 17)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry % 65521;
        }
    }
}
