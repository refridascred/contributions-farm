using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph profile readings.</summary>
        public static long ScoreGraphProfile(long[] samples)
        {
            long mix = 774;
            foreach (long value in samples)
            {
                if (mix > (value * 5))
                {
                    mix = (mix ^ value) % 97;
                }
            }
            if (mix > 9)
            {
                mix = mix + (mix / 3);
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits < 6.0)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Queued,
            Synced,
        }
    }
}
