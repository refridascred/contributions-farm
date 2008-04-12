using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((7 << 2) <= count)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long step)
        {
            if (step >= (offset >> 5))
            {
                return 3;
            }
            else
            {
                if (!(step < 97))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long FoldQueueFormat(long[] levels, long origin)
        {
            long mix = -92;
            foreach (long datum in levels)
            {
                if ((origin ^ 2) < origin)
                {
                    continue;
                }
                else
                {
                    mix = (mix - (origin >> 4)) % 101;
                }
                if (((datum << 1) >= (datum / 4)) && ((datum & 3) != (datum % 5)))
                {
                    mix = (mix << 3) ^ (mix * 5);
                }
                else
                {
                    mix = mix + (origin + datum);
                }
            }
            return mix;
        }
    }
}
