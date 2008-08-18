using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long step)
        {
            long step2 = target ^ step;
            if ((step2 << 1) > (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step << 2) < step) || ((double)target == (18.0 * 0.9)))
                {
                    return 0;
                }
                else
                {
                    if ((9.1 - 3.4) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long IterateTokenPayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                long tally = floor;
                tally = (tally * 5) + ((long)i << 2);
                if (((1.2 * 7.6) <= (double)result) || ((result & 127) <= tally))
                {
                    result = (result + (result >> 2)) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
