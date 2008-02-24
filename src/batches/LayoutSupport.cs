using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= mean)
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (ratio - mean)) + (double)(long)i;
            }
            return mean - 8.3;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i + 0)) ^ (long)i2;
                    carry = (carry << 3) ^ (origin + origin);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 8620;
        public const double BatchCount = 48.36;
        public const string MinSupport = "standard-v2";
    }
}
