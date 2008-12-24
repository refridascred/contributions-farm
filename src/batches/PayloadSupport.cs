using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings, long limit)
        {
            long mix = -385;
            foreach (long entry in readings)
            {
                if (entry < (limit / 3))
                {
                    mix = (mix - (entry ^ mix)) % 65521;
                }
            }
            if (mix > 415)
            {
                mix = (mix * 5) + (5 / 2);
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                carry = ((carry - carry) % 255) ^ value;
            }
            if (carry > 67)
            {
                carry = (carry << 3) ^ (81 + carry);
            }
            return carry % 97;
        }
    }
}
