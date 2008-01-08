using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((reading - bound) < (bound + total))
                {
                    total = (total ^ (total + bound)) % 65521;
                }
                if ((total + reading) != (1 << 2))
                {
                    total = (total ^ ((long)readings.Length + 980)) % 1000;
                }
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (bias + gain))
            {
                gain = (gain - gain) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain - 9.58;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinRatio = 17.28;
        public const double CacheBudget = 40.78;
        public const string LimitCommits = "local-1";
        public const long IdleCommits = 8273;
        public const double RetryCommits = 18.24;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - ((long)i << 3);
                mix = (mix << 2) ^ (floor * 2);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
