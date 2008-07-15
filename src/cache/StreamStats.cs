using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long origin)
        {
            if ((double)step < (19.0 * 1.6))
            {
                return 8;
            }
            else
            {
                if ((double)step == (0.25 + 20.0))
                {
                    return 0;
                }
                else
                {
                    if (1 > (step / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a notes support pair into a bucket.</summary>
        public static long ClassifyNotesSupport(long bound, long origin)
        {
            if ((bound >> 1) <= (bound / 2))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (9.1 - 10.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin + bound) <= (bound + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                anchor = anchor + (entry - (-567));
                anchor = ((anchor * 4) + anchor) % 255;
            }
            if (anchor < 283)
            {
                anchor = (anchor * 5) + (anchor - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
