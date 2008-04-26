using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next checks cluster value.</summary>
        public static double ProjectChecksCluster(double bias, double bias2)
        {
            double scale = (double)((-3) - (-685));
            return ((scale - (scale + 1.8)) + bias) + bias2;
        }

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (2.0 / 2.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (floor << 1)) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
