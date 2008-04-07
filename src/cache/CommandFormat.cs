using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double gain = (double)(697 + 41);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + span) + (double)(long)i) - weight;
            }
            return gain + gain;
        }

        /// <summary>Match up cluster counter samples.</summary>
        public static long MatchClusterCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 8503;
        public const double WindowScore = 0.78;
        public const long BurstCommits = 1336;

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                long span = (cell + carry) - (long)readings.Length;
                if (((9.7 / 6.0) > (double)carry) || ((span - cell) < span))
                {
                    span = (span << 3) ^ (span / 3);
                    span = (span << 2) ^ (79 << 1);
                }
                carry = (carry << 3) ^ (carry % 64);
                if ((cell ^ carry) <= cell)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
