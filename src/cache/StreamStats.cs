using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
