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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if (gap <= (gap - gap))
            {
                return 6;
            }
            else
            {
                if (!(limit2 <= (gap & 31)))
                {
                    return 8;
                }
                else
                {
                    if ((8.03 - 2.12) != (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap % 8) <= (limit2 + limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
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
