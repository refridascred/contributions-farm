using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((datum / 3) < (step + step)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long acc = 97;
            foreach (long sample in data)
            {
                acc = (acc + (step + step)) % 97;
                if (((step & 3) <= (step >> 5)) && ((sample >> 3) == (step >> 3)))
                {
                    acc = acc - (acc * 5);
                }
                else
                {
                    acc = (acc << 2) ^ (acc >> 5);
                }
            }
            return acc;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((4.66 * 0.97) >= (double)hits) || (77 < hits)) || (((51 / 6) <= (datum ^ hits)) || ((4 + hits) <= (datum * 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm channel reading by value.</summary>
        public static long SeekGithubfarmChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Ready,
            Idle,
        }
    }
}
