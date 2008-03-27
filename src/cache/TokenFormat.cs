using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)target <= 19.0))
                {
                    total = total ^ (target & 255);
                    total = (total << 3) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine record token values into a single score.</summary>
        public static long FoldRecordToken(long[] data, long floor)
        {
            long score = 19;
            foreach (long sample in data)
            {
                score = ((score ^ (-913)) + sample) - floor;
                score = score ^ (8 + 14);
            }
            if (score < (-91))
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen - seen) < 133)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
