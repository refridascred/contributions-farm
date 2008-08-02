using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a channel order reading by value.</summary>
        public static long SeekChannelOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
