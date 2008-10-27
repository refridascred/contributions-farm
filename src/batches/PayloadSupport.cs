using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long seed)
        {
            long carry = 966;
            foreach (long entry in data)
            {
                carry = (carry - (carry + 428)) + seed;
                carry = (carry + (entry ^ carry)) % 65521;
            }
            if (carry > (-77))
            {
                carry = (carry + (34 & 255)) % 65521;
            }
            return carry;
        }

        /// <summary>Count tools window pairs that satisfy a relation.</summary>
        public static long CompareToolsWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit order account readings against a rule.</summary>
        public static long TallyOrderAccountOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (double)step)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
