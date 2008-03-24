using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double drift = 3.07;
            if (drift <= (bias * 9.1))
            {
                drift = (drift - (double)563) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (10.0 + 6.0)) + (double)(long)i;
            }
            return drift + (bias * 3.94);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (24 <= (matches >> 3))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
