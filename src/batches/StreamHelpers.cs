using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinRatio = "cached-1";
        public const double StepBudget = 36.29;
        public const long SoftSupport = 9533;
        public const double MinInterval = 54.19;
        public const long WindowSupport = 9595;

        /// <summary>Locate a githubfarm already reading by value.</summary>
        public static long FindGithubfarmAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context stats input into a small class.</summary>
        public static long ClassifyContextStats(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((step << 3) < (65 << 2))
            {
                return 7;
            }
            else
            {
                if ((seed * 4) == (seed - step))
                {
                    return 2;
                }
                else
                {
                    if ((80 % 3) > (limit ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step) < (step % 60)) && ((double)step < (double)limit))
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

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Retry,
            Failed,
            Draft,
        }
    }
}
