using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)step < (double)seen))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 4) + (carry - (long)i);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account stream entries.</summary>
        public static long ScoreAccountStream(long[] data)
        {
            long mix = 244;
            foreach (long item in data)
            {
                mix = (mix << 3) ^ (item ^ mix);
            }
            return mix;
        }
    }
}
