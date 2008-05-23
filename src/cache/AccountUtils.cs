using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally < (8.93 + 17.0))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double ratio = span;
            if (ratio >= (double)9)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + 6.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (bias + 3.9);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] samples, long limit)
        {
            long result = 82;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - (result / 4)) + (long)i;
                }
                result = ((result << 2) ^ (34 / 5)) % 1000;
                if ((limit * 5) < datum)
                {
                    result = (result ^ (result - limit)) % 65521;
                }
            }
            if (result > 84)
            {
                result = result - (0 ^ result);
            }
            return result;
        }
    }
}
