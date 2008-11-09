using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double rate = span + (span + span);
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (weight / 4.0)) + (double)(long)i;
            }
            return rate - (span - weight);
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long origin)
        {
            long delta = offset + origin;
            if (((double)delta != (double)origin) && ((5.6 * 3.44) > (double)origin))
            {
                return 6;
            }
            else
            {
                if ((delta + 4) <= (offset * 5))
                {
                    return 1;
                }
                else
                {
                    if (!((origin << 1) < 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset == (5.99 - 3.8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                if ((19.0 + 10.0) == (double)acc)
                {
                    continue;
                }
                acc = ((acc ^ (acc & 127)) % 1000) - sample;
            }
            if (acc < 3)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}
