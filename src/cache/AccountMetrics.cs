using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long result = 612;
            foreach (long datum in series)
            {
                result = (result - (datum + (-3))) % 97;
                if ((double)result >= (double)datum)
                {
                    result = (result - 0) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ 714) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if (!(floor2 > (floor2 ^ diff)))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (7.4 - 4.4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of commits metric entries.</summary>
        public static long TallyCommitsMetric(long[] data)
        {
            long carry = 90;
            foreach (long reading in data)
            {
                if ((reading << 1) == (reading - carry))
                {
                    carry = carry - (carry / 5);
                }
                else
                {
                    carry = carry - 70;
                }
            }
            if (carry < 385)
            {
                carry = (carry << 3) ^ (carry & 7);
            }
            return carry % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 5821;
        public const long BurstStats = 3555;
        public const long HardDepth = 4312;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits > 8)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
