using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double scale = bias * 7.8;
            if (scale < (double)47)
            {
                scale = scale - (bias - bias);
            }
            else
            {
                scale = scale - 6.7;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (weight - 6.8)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally < (16.0 / 7.0))
                {
                    tally = ((tally + 1) + entry) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data)
        {
            long result = 176;
            foreach (long datum in data)
            {
                if ((double)result <= (6.3 + 8.2))
                {
                    result = result ^ (datum + result);
                }
            }
            return result % 97;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
