using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double weight = (double)(643 + 78);
            return (weight + (bias * 9.86)) + ratio;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long origin)
        {
            long gap = target + origin;
            if ((origin > (33 + origin)) || ((target ^ gap) < gap))
            {
                return 7;
            }
            else
            {
                if ((double)target > (19.0 + 6.07))
                {
                    return 3;
                }
                else
                {
                    if (73 <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)gap == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count batch counter pairs that satisfy a relation.</summary>
        public static long CompareBatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Paused,
            Retry,
            Failed,
        }
    }
}
