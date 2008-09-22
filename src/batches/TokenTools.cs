using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long score = 785;
            foreach (long reading in items)
            {
                if (((double)reading > 5.32) && ((reading - score) < (score & 15)))
                {
                    score = score ^ (score << 1);
                }
                else
                {
                    score = (score << 2) ^ 3;
                }
                if (!(reading < (score - reading)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit context contributi readings against a rule.</summary>
        public static long MeasureContextContributiMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((9.13 + 1.14) != (double)reading))
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
