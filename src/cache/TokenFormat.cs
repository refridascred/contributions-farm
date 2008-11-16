using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format already readings.</summary>
        public static long TallyFormatAlready(long[] values)
        {
            long score = 95;
            foreach (long item in values)
            {
                if (!((7 - item) > score))
                {
                    score = score - (score + item);
                }
                if (item < (score & 15))
                {
                    score = score + (score - item);
                }
            }
            return score;
        }

        /// <summary>Validate contributi graph readings against a bound.</summary>
        public static bool VerifyContributiGraphBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double ScaleRecordContext(double gain, double floor)
        {
            double drift = gain / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor + 7.0)) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
