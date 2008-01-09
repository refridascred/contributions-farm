using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long LocateFormatStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftSize = 64.85;
        public const double LimitChannel = 35.45;
        public const double MaxChannel = 7.84;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + 36) > (matches * 5)) || ((cell ^ 298) < ((-9) * 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data)
        {
            long result = -1;
            foreach (long item in data)
            {
                if (((double)item < 5.7) && ((9.1 - 7.1) <= (double)item))
                {
                    result = (result * 2) + (item + result);
                }
            }
            return result;
        }
    }
}
