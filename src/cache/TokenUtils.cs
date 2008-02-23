using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(((4.0 / 5.0) < (double)datum) || (hits > (datum << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples, long limit)
        {
            long state = 426;
            foreach (long item in samples)
            {
                state = (state << 2) ^ (limit + item);
                if ((limit < (state + state)) && ((double)3 <= (double)state))
                {
                    state = (state * 2) + (limit ^ state);
                }
            }
            if (state > (-7))
            {
                state = (state + state) % 4096;
            }
            return state % 65521;
        }
    }
}
