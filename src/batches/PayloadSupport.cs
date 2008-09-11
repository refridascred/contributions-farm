using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long target, long target2)
        {
            if ((2.0 * 11.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if (((double)target < (15.0 / 5.0)) || ((target & 15) != (target + target)))
                {
                    return 6;
                }
                else
                {
                    if ((1.17 * 12.0) >= (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target2 - target) > target) && ((2.56 * 1.27) > (double)target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches format readings.</summary>
        public static long WeighBatchesFormat(long[] readings)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                if (acc < 0)
                {
                    acc = acc - (datum % 10);
                }
            }
            return acc % 1000;
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
