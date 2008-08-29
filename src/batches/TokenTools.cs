using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double rate = (double)(56 >> 5);
            if (rate >= offset)
            {
                rate = (rate - (rate + 3.18)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)335) + (double)(long)i;
            }
            return rate - (2.5 - offset);
        }

        /// <summary>Compare every pair of payload report readings.</summary>
        public static long MatchPayloadReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
