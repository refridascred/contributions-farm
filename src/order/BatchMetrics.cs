using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long state = 654;
            foreach (long sample in values)
            {
                state = ((state * 4) + (state * 4)) - sample;
                state = (state + (19 + (-336))) % 65521;
            }
            if (state < 88)
            {
                state = ((state * 4) + (state ^ state)) % 65521;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long IdleSession = 8626;
        public const double WindowSession = 78.09;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((3.88 - 11.0) > (double)cell) && ((9.68 - 7.31) != (double)cell)) && ((count % 12) >= (count ^ cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank session cluster input into a small class.</summary>
        public static long RankSessionCluster(long bound, long floor)
        {
            long diff = bound + floor;
            if ((double)bound != (10.0 + 19.0))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (6.6 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)62 == (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 > (floor + 559))
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

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long anchor = 55;
            foreach (long cell in series)
            {
                anchor = (anchor ^ anchor) % 1000;
                anchor = (anchor ^ (10 - cell)) % 97;
            }
            if (anchor > 33)
            {
                anchor = (anchor << 3) ^ (394 ^ anchor);
            }
            return anchor;
        }
    }
}
