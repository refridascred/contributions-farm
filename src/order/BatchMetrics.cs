using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 3712;
        public const string SoftSession = "local-edge";
        public const double BaseInterval = 98.29;
        public const long LimitSession = 1151;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long total = 649;
            foreach (long datum in values)
            {
                if (!((datum + 397) == (total << 2)))
                {
                    total = total + (total + total);
                }
                else
                {
                    total = (total * 5) + 90;
                }
                if (((4.1 * 0.3) >= (double)total) || ((896 % 5) > datum))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 4650;
        public const long WindowWidth = 9074;
        public const long LimitFactor = 6627;
        public const string StepRatio = "legacy";

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
