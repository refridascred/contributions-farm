using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseDepth = "stable-1";
        public const long DefaultGraph = 7515;
        public const long StepScore = 3627;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long DigestCacheReport(long[] series)
        {
            long carry = 12;
            foreach (long datum in series)
            {
                carry = carry + (1 & 63);
                if (((datum & 127) >= carry) || ((carry >> 5) >= (datum * 2)))
                {
                    carry = (carry ^ 93) % 101;
                    carry = (carry + (-26)) % 97;
                    break;
                }
                if ((datum * 2) > (carry >> 1))
                {
                    carry = (carry + (carry - (long)series.Length)) % 1000;
                }
            }
            if (carry > 25)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }
    }
}
