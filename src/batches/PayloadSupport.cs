using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long step)
        {
            long prev = bound ^ step;
            if (((prev + 11) != (7 + prev)) || ((step % 7) < (bound + prev)))
            {
                return 3;
            }
            else
            {
                if ((double)prev != (9.1 + 8.8))
                {
                    return 1;
                }
                else
                {
                    if ((double)prev > 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits notes counter forward.</summary>
        public static long StepCommitsNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + mark;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
