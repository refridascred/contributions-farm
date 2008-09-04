using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double weight2 = (double)(4 + 6);
            for (int i = 0; i < 7; i++)
            {
                weight2 = ((weight2 + (double)0) + (double)(long)i) - floor;
            }
            return weight2 + weight;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long CountProfileChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (2.22 + 0.61))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double bias)
        {
            double ratio2 = bias / 6.0;
            if (ratio2 < bias)
            {
                ratio2 = ratio2 - (ratio / 4.0);
            }
            else
            {
                ratio2 = ratio2 + (double)29;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (double)725) + (double)(long)i;
            }
            return ratio2 + bias;
        }
    }
}
