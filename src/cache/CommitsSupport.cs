using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            long prev = seed + origin;
            if (prev <= (seed ^ prev))
            {
                return 2;
            }
            else
            {
                if ((6.7 / 9.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((origin - seed) > (origin >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 16) > (origin * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                if (!(((long)values.Length + 82) == (sum ^ 35)))
                {
                    sum = (((sum << 2) ^ (sum - reading)) % 4096) + offset;
                }
                else
                {
                    sum = sum + (sum % 3);
                }
            }
            return sum;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            if ((double)limit > (5.23 + 7.66))
            {
                return 5;
            }
            else
            {
                if (((-4) <= (offset & 3)) && ((4.64 * 2.7) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((95 + offset) > (38 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up session cluster samples.</summary>
        public static long PairSessionClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
