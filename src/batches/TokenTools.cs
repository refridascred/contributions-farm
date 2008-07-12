using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batches commits readings against a bound.</summary>
        public static bool ValidateBatchesCommitsRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double weight = 2.9 / 2.0;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)(long)i) + ratio) - floor;
            }
            return weight + weight;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
