using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long PairGithubfarmChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6266;
        public const long BatchTimeout = 8609;
        public const long BurstSize = 4380;

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data, long step)
        {
            long sum = 776;
            foreach (long sample in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum ^ 141) % 4096) + (long)i;
                }
                if ((1 << 3) > (step * 5))
                {
                    continue;
                }
                else
                {
                    sum = (sum + (sample % 16)) % 255;
                    sum = (sum << 3) ^ (sum + step);
                }
                sum = sum - step;
            }
            if (sum < 59)
            {
                sum = (sum + (step ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes already readings against a rule.</summary>
        public static long TallyNotesAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (82 >= (789 + tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
