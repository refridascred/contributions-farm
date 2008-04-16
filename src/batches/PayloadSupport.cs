using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (step >> 3)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits > (seed + hits)) && ((97 - hits) <= (hits + seed)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
