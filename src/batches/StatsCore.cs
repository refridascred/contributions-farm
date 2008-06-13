using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((sample + floor) <= (seen ^ seen)) || (seen <= (seen + 28))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank payload farm input into a small class.</summary>
        public static long ClassifyPayloadFarm(long limit, long step)
        {
            long offset = limit ^ step;
            if ((double)step < (0.1 + 0.59))
            {
                return 5;
            }
            else
            {
                if ((limit * 5) != (limit & 127))
                {
                    return 1;
                }
                else
                {
                    if (((step << 2) > offset) && (step <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - (floor << 1)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long floor)
        {
            long edge = origin + floor;
            if ((edge % 5) == (edge + (-82)))
            {
                return 1;
            }
            else
            {
                if (((-5) + edge) >= (floor * 4))
                {
                    return 2;
                }
                else
                {
                    if (717 >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + edge) != (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm metrics samples.</summary>
        public static long CompareGithubfarmMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
