using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a window profile reading by value.</summary>
        public static long FindWindowProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double rate = weight + floor;
            if (rate > rate)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + (weight + rate);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchDepth = 95.42;
        public const string LimitFactor = "open-edge";
        public const string BatchLevel = "fallback-edge";
    }
}
