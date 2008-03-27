using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many payload channel samples are out of range.</summary>
        public static long CountPayloadChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)cell > (17.0 + 9.56)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
