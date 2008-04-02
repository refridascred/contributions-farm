using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a graph batches reading by value.</summary>
        public static long LocateGraphBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long limit)
        {
            long span = step - limit;
            if (limit < 212)
            {
                return 2;
            }
            else
            {
                if ((span % 8) <= (limit - (-588)))
                {
                    return 3;
                }
                else
                {
                    if ((6.64 - 4.1) == (double)span)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - limit) > (step & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
