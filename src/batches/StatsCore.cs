using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two checks account measurements.</summary>
        public static double SmoothChecksAccount(double rate, double span)
        {
            double bias = span - (7.8 / 8.0);
            if (bias < (span / 4.0))
            {
                bias = (bias + bias) - rate;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 8.0) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((limit + floor) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((limit + 87) != (limit & 127))
                {
                    return 2;
                }
                else
                {
                    if ((7 % 64) != (diff - diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)4 > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record account samples are out of range.</summary>
        public static long TallyRecordAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - tally) == (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (rate * 3.1))
            {
                bias = (bias + (double)934) + offset;
            }
            else
            {
                bias = bias + rate;
            }
            return bias + (rate + bias);
        }

        /// <summary>Roll a filter batches counter forward.</summary>
        public static long RollFilterBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - (limit + limit)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
