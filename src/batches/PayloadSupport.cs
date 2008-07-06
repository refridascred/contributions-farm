using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (1.9 < (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = carry ^ ((-2) + (long)i);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values, long floor)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((score + 4) > (cell + floor))
                {
                    score = (score * 5) + (floor * 5);
                }
                else
                {
                    score = score ^ (floor + floor);
                }
            }
            if (score > 129)
            {
                score = (score + (floor & 63)) % 255;
            }
            return score % 1000;
        }
    }
}
