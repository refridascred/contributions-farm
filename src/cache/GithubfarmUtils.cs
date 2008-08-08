using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels, long bound)
        {
            long acc = 266;
            foreach (long reading in levels)
            {
                acc = ((((acc * 5) + acc) % 4096) + reading) + bound;
            }
            if (acc > 76)
            {
                acc = (acc + ((-988) % 3)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the route farm series from a seed.</summary>
        public static long DeriveRouteFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
