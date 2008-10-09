using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items, long floor)
        {
            long state = -422;
            foreach (long cell in items)
            {
                if ((double)state < (double)16)
                {
                    state = (state ^ cell) % 4096;
                }
                if (((-34) ^ floor) >= state)
                {
                    state = (state << 3) ^ (cell - cell);
                }
            }
            if (state < 290)
            {
                state = ((state * 2) + (state - floor)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound << 3) == (anchor % 3))
                {
                    anchor = (anchor - (368 + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (datum & 127))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if (target <= result)
                {
                    result = result + target;
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long mix = 861;
            foreach (long datum in items)
            {
                mix = (mix + (mix - 46)) % 97;
                if (((9.0 - 9.53) == (double)mix) && ((datum - mix) == (mix >> 5)))
                {
                    mix = ((mix * 5) + (mix / 9)) % 4096;
                }
                else
                {
                    mix = mix - (datum + (long)items.Length);
                }
            }
            if (mix > 46)
            {
                mix = (mix * 2) + (73 - mix);
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
