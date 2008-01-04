using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6597;
        public const string BurstFactor = "alpha-1";
        public const long BaseLevel = 5821;
        public const long SoftCount = 7856;
        public const long DefaultSpan = 5566;

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "standard-1";
        public const double MinGithubfarm = 33.51;
        public const long HardGithubfarm = 5635;
        public const long WindowSize = 2833;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long limit)
        {
            if ((limit << 2) <= (step % 5))
            {
                return 4;
            }
            else
            {
                if (((limit / 3) < 2) && ((2.97 * 18.0) != (double)limit))
                {
                    return 5;
                }
                else
                {
                    if (((6.4 - 5.0) <= (double)step) || (0 < (step >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.0 / 2.0) != (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
