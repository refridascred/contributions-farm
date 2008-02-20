using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 10.14;
        public const double HardReport = 42.48;
        public const double BaseReport = 93.64;
        public const long IdleReport = 5391;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((origin % 64) >= origin)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long seed)
        {
            if (764 <= (target / 2))
            {
                return 3;
            }
            else
            {
                if ((target % 10) > (seed << 1))
                {
                    return 7;
                }
                else
                {
                    if (target <= 801)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((66 / 8) >= (seed % 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
