using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if ((state - state) >= (state & 1))
                {
                    state = ((state << 3) ^ (state ^ cell)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Synced,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels, long limit)
        {
            long total = 455;
            foreach (long sample in levels)
            {
                if (total >= (limit + limit))
                {
                    total = total - sample;
                    break;
                }
                if (!(total <= (7 + limit)))
                {
                    total = ((total * 4) + (total ^ total)) % 255;
                }
                else
                {
                    total = (total - (total + limit)) % 97;
                }
                if (((double)limit >= (13.0 / 9.0)) && ((sample + sample) < limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long seed)
        {
            if ((origin & 7) < origin)
            {
                return 1;
            }
            else
            {
                if ((seed * 4) < (seed << 3))
                {
                    return 0;
                }
                else
                {
                    if (origin > (942 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if (mix < 990)
                {
                    mix = ((mix ^ (mix + 656)) % 97) ^ datum;
                }
            }
            return mix % 65521;
        }
    }
}
