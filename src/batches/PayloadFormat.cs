using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long target)
        {
            if ((76 - 29) >= (step & 1))
            {
                return 7;
            }
            else
            {
                if ((target - step) > (target & 3))
                {
                    return 8;
                }
                else
                {
                    if (step >= (target - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((14.0 * 4.9) > (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a queue report reading.</summary>
        public static double ProjectQueueReport(double weight, double offset)
        {
            double mean = weight;
            if (mean > (mean * 4.8))
            {
                mean = mean + (double)31;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (weight - weight);
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
