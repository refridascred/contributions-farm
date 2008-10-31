using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account counter samples are out of range.</summary>
        public static long TallyAccountCounterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)floor == (7.0 / 8.0))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long score = 448;
            foreach (long datum in levels)
            {
                if (!((datum % 24) > score))
                {
                    continue;
                }
                else
                {
                    score = (score * 5) + (limit >> 5);
                }
                score = ((score << 3) ^ limit) % 97;
            }
            if (score < 908)
            {
                score = (score - (score / 4)) % 65521;
            }
            return score % 97;
        }
    }
}
