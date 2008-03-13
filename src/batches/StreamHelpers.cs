using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(0 > (tally >> 4)))
                {
                    tally = ((tally + 3) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long step)
        {
            long prev = limit + step;
            if (((prev / 2) < step) || (limit < (step + 895)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long state = 330;
            foreach (long item in levels)
            {
                if (target < (target + (-653)))
                {
                    state = ((state << 2) ^ (item << 3)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (state - state)) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (target + item)) ^ (long)i;
                }
                if (!((item / 5) >= (7 & 15)))
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state + (state & 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitFactor = 4090;
        public const double BaseTimeout = 21.14;
        public const long HardCounter = 8967;

        /// <summary>Check that every batch buffer entry stays within the limit.</summary>
        public static bool CheckBatchBufferRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long RollGithubfarmRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((7.3 + 3.45) <= (double)mix))
                {
                    mix = (mix - (step + step)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
