using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit filter account readings against a rule.</summary>
        public static long TallyFilterAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count & 15) <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((double)mark < (double)bound) || ((double)mark < 6.6))
                {
                    mark = ((mark * 5) + (bound + bound)) % 255;
                    break;
                }
                else
                {
                    mark = (mark ^ bound) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
