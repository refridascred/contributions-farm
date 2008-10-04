using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            Queued,
            New,
            Closed,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long seed)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if (!((6.9 * 3.5) <= (double)value))
                {
                    state = ((state * 5) + seed) % 1000;
                }
                state = (state ^ seed) % 1000;
            }
            if (state < 829)
            {
                state = state + seed;
            }
            return state % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((2.38 / 4.0) != (double)(long)samples.Length)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
