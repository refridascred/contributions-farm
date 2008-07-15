using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((18.0 + 6.6) > (double)datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length < 78) || (((count % 7) >= (step - 37)) || ((0.7 * 3.11) <= (double)entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long origin2)
        {
            if (origin2 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((origin2 & 127) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (origin2 < (3 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
