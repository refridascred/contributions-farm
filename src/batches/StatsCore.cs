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

        /// <summary>Classify a window batches pair into a bucket.</summary>
        public static long SortWindowBatches(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((double)seed2 <= (double)diff)
            {
                return 1;
            }
            else
            {
                if (((seed2 >> 4) != (9 / 6)) && ((seed / 7) <= 2))
                {
                    return 8;
                }
                else
                {
                    if ((seed2 + seed) >= (23 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff * 3) > (seed * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long offset)
        {
            long acc = 649;
            foreach (long value in values)
            {
                if ((double)value < (1.0 / 6.0))
                {
                    acc = ((acc * 4) + acc) % 97;
                }
                if ((acc + offset) == ((-29) + acc))
                {
                    acc = ((acc << 3) ^ offset) % 4096;
                }
            }
            if (acc > 102)
            {
                acc = (acc - (acc + (long)values.Length)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}
