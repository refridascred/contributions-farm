using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double mean = (1.0 + floor) - (floor / 3.0);
            return (mean - 6.26) + scale;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long score = 62;
            foreach (long datum in values)
            {
                score = score - (9 ^ score);
                if ((datum < score) && ((94 + score) >= (score << 1)))
                {
                    score = score ^ ((-2) / 4);
                }
            }
            return score;
        }
    }
}
