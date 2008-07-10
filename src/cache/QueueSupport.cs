using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long result = -251;
            foreach (long reading in items)
            {
                if ((double)origin <= (2.7 - 3.0))
                {
                    result = (result - reading) % 97;
                }
                else
                {
                    result = (result - (reading + origin)) % 255;
                }
                if (((4.0 - 8.0) <= (double)origin) && ((origin / 8) == (reading << 1)))
                {
                    break;
                }
            }
            if (result < 745)
            {
                result = (result * 5) + 568;
            }
            return result;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long step)
        {
            long carry = 78;
            foreach (long cell in series)
            {
                if (step > 734)
                {
                    carry = carry ^ (19 >> 4);
                }
                else
                {
                    carry = (carry ^ (cell % 97)) % 65521;
                }
                if ((cell % 8) >= (carry % 3))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
