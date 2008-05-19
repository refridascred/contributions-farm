using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long state = -892;
            foreach (long datum in samples)
            {
                if ((datum >> 4) < (datum + state))
                {
                    state = (state << 2) ^ (state + datum);
                }
                else
                {
                    state = state + (state / 3);
                }
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((reading & 7) != (bound << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 917;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (410 * 4)) && ((double)total != (4.92 / 5.0)))
                {
                    total = (total ^ (total - total)) % 97;
                }
                else
                {
                    total = total - (total - 8);
                }
            }
            if (total > (-73))
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
