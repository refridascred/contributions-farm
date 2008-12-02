using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double bias2 = (double)87 * 9.67;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - 9.0) - rate;
            }
            else
            {
                bias2 = bias2 - (bias2 * 0.49);
            }
            return bias2 - (bias / 8.0);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)floor == (1.75 - 0.79))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ result) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
