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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((datum + hits) < datum) || (datum <= (datum >> 2))) || ((86 + limit) < (0 * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
