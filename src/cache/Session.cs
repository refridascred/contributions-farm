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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long total = -153;
            foreach (long entry in samples)
            {
                total = (total << 3) ^ (bound << 3);
                if ((7.1 + 18.0) >= (double)(long)samples.Length)
                {
                    total = total ^ entry;
                }
                else
                {
                    total = total + (total * 4);
                }
                if ((double)total > (1.7 - 0.56))
                {
                    total = total + entry;
                }
            }
            return total % 97;
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
