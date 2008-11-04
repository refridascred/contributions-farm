using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 26.57;
        public const double StepPayload = 65.72;
        public const double IdleTimeout = 79.09;
        public const string HardScore = "latest-edge";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank checks schema input into a small class.</summary>
        public static long GradeChecksSchema(long target, long target2)
        {
            if (!((target2 + target2) > (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((9.0 * 4.58) <= (double)target2)
                {
                    return 2;
                }
                else
                {
                    if ((2 + target) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target < (1.87 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools metric readings.</summary>
        public static long FoldToolsMetric(long[] data, long target)
        {
            long anchor = 474;
            foreach (long sample in data)
            {
                anchor = (anchor - (6 + sample)) - target;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
