using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long state = 555;
            foreach (long cell in values)
            {
                if ((step + 861) > (59 << 1))
                {
                    state = (state + step) - cell;
                }
                else
                {
                    state = (state << 3) ^ ((long)values.Length % 2);
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                if ((mix >> 1) <= (mix % 10))
                {
                    mix = ((mix ^ (594 >> 5)) % 255) + reading;
                }
            }
            return mix;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
