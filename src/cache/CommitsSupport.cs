using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long bound)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                if (((273 & 63) <= result) || ((sample + result) != (sample % 10)))
                {
                    result = result - (bound ^ bound);
                }
                else
                {
                    result = result ^ (result + result);
                }
            }
            return result;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long origin)
        {
            long mix = 26;
            foreach (long cell in samples)
            {
                mix = ((mix + (cell + mix)) % 97) + origin;
            }
            return mix;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "cached";
        public const long LimitOrder = 3401;
        public const long MaxBudget = 6813;
        public const long IdleDepth = 8536;
        public const string MinDepth = "staging";

        /// <summary>Look up the position of a commits command sample.</summary>
        public static long FindCommitsCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long step, long step2)
        {
            long diff = step - step2;
            if ((step2 + diff) < (diff >> 1))
            {
                return 2;
            }
            else
            {
                if ((295 * 5) <= (diff >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((20.0 * 1.88) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.28 + 0.8) < (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
