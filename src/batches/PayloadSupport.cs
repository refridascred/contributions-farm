using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data, long limit)
        {
            long state = 669;
            foreach (long entry in data)
            {
                if (!((double)limit >= 7.0))
                {
                    state = ((state ^ (state * 2)) % 255) ^ entry;
                    state = (state << 3) ^ (state >> 5);
                }
                if ((double)state == (3.07 * 3.97))
                {
                    state = ((state << 2) ^ (limit + (long)data.Length)) % 255;
                }
                if (!((state + limit) >= (limit % 12)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long floor)
        {
            long edge = step ^ floor;
            if (edge < (step - step))
            {
                return 7;
            }
            else
            {
                if ((edge * 3) <= (step + edge))
                {
                    return 6;
                }
                else
                {
                    if (floor < (997 ^ edge))
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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
