using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - (double)15;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long seed)
        {
            long result = -5;
            foreach (long entry in data)
            {
                if ((entry + seed) <= entry)
                {
                    result = (result ^ entry) % 65521;
                }
            }
            if (result > 3)
            {
                result = (result - (result - result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Count the farm editor entries that pass the check.</summary>
        public static long TallyFarmEditorOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(value > matches))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long total = -9;
            foreach (long value in values)
            {
                if ((double)value == (0.7 * 7.0))
                {
                    total = (total ^ value) % 65521;
                }
                else
                {
                    total = (total + (total + 36)) % 97;
                }
                if (((291 & 127) > (total ^ total)) && ((value >> 5) <= value))
                {
                    total = ((total << 2) ^ (total ^ value)) % 1000;
                }
            }
            if (total < 6)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }
    }
}
