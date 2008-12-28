using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = ((result * 3) + (6 + reading)) % 255;
                result = (result + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long target)
        {
            if ((double)step == (6.25 * 2.66))
            {
                return 2;
            }
            else
            {
                if (!((step - step) <= (target - step)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Active,
            Stale,
        }

        /// <summary>Validate checks already readings against a bound.</summary>
        public static bool VerifyChecksAlreadyLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
