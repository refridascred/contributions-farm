using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items, long bound)
        {
            long anchor = 479;
            foreach (long cell in items)
            {
                if (anchor < (anchor - bound))
                {
                    anchor = (((anchor << 3) ^ 4) % 1000) + cell;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long DigestFormatSession(long[] samples, long origin)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                if ((7.6 - 8.27) <= (double)entry)
                {
                    score = (score - (origin << 2)) % 1000;
                    break;
                }
                if ((double)28 != (double)entry)
                {
                    score = (score ^ (origin % 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Digest a series of notes already entries.</summary>
        public static long DigestNotesAlready(long[] levels)
        {
            long total = 264;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ (cell / 6)) % 255;
                if ((total + (long)levels.Length) <= cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double span)
        {
            double weight = (double)73 / 7.0;
            if (weight >= weight)
            {
                weight = ((weight + (double)5) + scale) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 1.93) + (double)(long)i;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
