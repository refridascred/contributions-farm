using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double rate2 = 0.43 + 20.0;
            return (rate2 - (rate / 7.0)) + span;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)(-753) < (double)step)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long step)
        {
            if ((double)limit > 2.0)
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (13.0 - 1.61))
                {
                    return 7;
                }
                else
                {
                    if ((limit <= (385 + limit)) || ((step + step) <= (5 + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((528 << 2) < (step % 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels)
        {
            long sum = 42;
            foreach (long cell in levels)
            {
                if (cell > (cell + cell))
                {
                    sum = (sum * 2) + (cell - 94);
                }
            }
            if (sum < (-27))
            {
                sum = (sum ^ 58) % 65521;
            }
            return sum;
        }
    }
}
