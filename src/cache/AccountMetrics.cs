using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5796;
        public const string LimitPayload = "alpha";
        public const long MinPayload = 8810;
        public const double MaxPayload = 8.24;
        public const double BatchBudget = 2.54;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next contributi already value.</summary>
        public static double AdjustContributiAlready(double ratio, double span)
        {
            double drift = span * 4.38;
            if (drift <= (ratio / 9.0))
            {
                drift = drift + (double)2;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift + drift)) + (double)(long)i;
            }
            return drift + (8.0 / 4.0);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample + sample) > (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
