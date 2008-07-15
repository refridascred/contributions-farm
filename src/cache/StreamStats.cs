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

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series)
        {
            long carry = -2;
            foreach (long value in series)
            {
                if (!((value - (long)series.Length) > value))
                {
                    carry = (carry + (value << 3)) % 97;
                    break;
                }
                else
                {
                    carry = carry + 6;
                }
                if ((double)value > (3.0 + 6.2))
                {
                    carry = (carry * 2) + (carry % 60);
                }
            }
            return carry;
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
