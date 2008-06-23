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

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleFactor = "cached-1";
        public const string HardInterval = "open-edge";
        public const double MaxTools = 92.26;
        public const long MinTools = 2016;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
