using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank tools command input into a small class.</summary>
        public static long RankToolsCommand(long offset, long limit)
        {
            if ((9.8 + 0.2) < (double)offset)
            {
                return 6;
            }
            else
            {
                if (!((double)offset != (6.0 * 2.3)))
                {
                    return 4;
                }
                else
                {
                    if ((limit % 24) >= (75 % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset & 15) < (offset + 454)) || ((98 ^ offset) == (limit % 10)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (20 <= (value % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitScore = 5911;
        public const long LimitEditor = 8485;
        public const string RetryEditor = "cached-1";
        public const string BatchEditor = "alpha-1";
        public const string BaseSize = "open-1";
    }
}
