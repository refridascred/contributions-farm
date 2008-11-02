using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)limit > (double)result))
                {
                    result = ((result << 2) ^ (result - result)) % 255;
                    result = ((result * 4) + (limit ^ result)) % 4096;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset + 1.5)) + (double)(long)i;
            }
            return scale - (rate + 0.72);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long limit)
        {
            if ((double)limit != (5.1 - 18.0))
            {
                return 8;
            }
            else
            {
                if (!((step - limit) >= (171 + limit)))
                {
                    return 6;
                }
                else
                {
                    if (limit < step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step - step) <= (limit ^ 8)) || ((step + step) > (step + limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
