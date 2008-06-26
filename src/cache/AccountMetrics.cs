using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series, long target)
        {
            long mix = -77;
            foreach (long reading in series)
            {
                mix = mix ^ (mix + reading);
                if ((reading / 9) >= (mix - target))
                {
                    mix = (mix - (target ^ reading)) % 65521;
                }
                if ((338 >= reading) || (mix <= (reading - 16)))
                {
                    break;
                }
            }
            if (mix > 88)
            {
                mix = (mix - (mix - (-781))) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches editor readings against a bound.</summary>
        public static bool ValidateBatchesEditorBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item != (8.99 / 4.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 306;
            foreach (long item in levels)
            {
                state = ((state - state) % 101) + item;
            }
            return state;
        }

        /// <summary>Roll a commits session counter forward.</summary>
        public static long RollCommitsSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 3) ^ (target >> 5);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
