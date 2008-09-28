using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up metrics metric samples.</summary>
        public static long PairMetricsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long target, long step)
        {
            long cur = target + step;
            if (((2.0 / 6.0) < (double)target) && ((15 * 3) >= (step / 4)))
            {
                return 6;
            }
            else
            {
                if (18.0 > (double)cur)
                {
                    return 7;
                }
                else
                {
                    if ((step % 12) < (cur ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur - target) < cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
