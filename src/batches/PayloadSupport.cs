using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (entry ^ count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                if ((cell >= 5) && ((mix + cell) <= (cell ^ mix)))
                {
                    mix = mix + ((-2) >> 1);
                }
            }
            if (mix < 51)
            {
                mix = ((mix * 2) + (mix / 6)) % 1000;
            }
            return mix;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
