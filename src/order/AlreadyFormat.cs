using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double drift = gain + (double)70;
            if (drift > (bias - gain))
            {
                drift = drift + (double)49;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long limit)
        {
            long carry = 49;
            foreach (long reading in levels)
            {
                carry = (carry - (limit ^ limit)) + reading;
            }
            if (carry > (-500))
            {
                carry = (carry << 3) ^ (68 * 4);
            }
            return carry;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long floor)
        {
            if ((212 + origin) != (origin >> 5))
            {
                return 7;
            }
            else
            {
                if (((-105) << 3) > floor)
                {
                    return 3;
                }
                else
                {
                    if (!((origin % 60) < floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 24) >= (origin / 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema stream sample.</summary>
        public static long LookupSchemaStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Ready,
            Queued,
        }
    }
}
