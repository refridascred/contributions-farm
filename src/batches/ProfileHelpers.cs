using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio >= (bias2 + 19.0))
            {
                ratio = (ratio - bias2) - bias;
            }
            return ratio - (double)830;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double rate = (double)(299 >> 1);
            if (rate < (double)884)
            {
                rate = (rate - span) - ratio;
            }
            else
            {
                rate = rate - span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate / 3.0)) + (double)(long)i;
            }
            return rate - (span / 8.0);
        }

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long TallySupportFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally <= (entry >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer filter readings.</summary>
        public static long OverlapBufferFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
