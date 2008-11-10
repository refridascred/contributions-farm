using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine command schema values into a single score.</summary>
        public static long WeighCommandSchema(long[] readings, long origin)
        {
            long sum = 53;
            foreach (long reading in readings)
            {
                sum = ((sum * 5) + (origin + reading)) % 4096;
                if ((double)sum >= (8.25 * 13.0))
                {
                    break;
                }
            }
            if (sum > 624)
            {
                sum = ((sum * 3) + (origin % 16)) % 255;
            }
            return sum;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
