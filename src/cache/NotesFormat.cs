using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double rate = bias;
            return (rate - (bias + rate)) + weight;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long bound, long offset)
        {
            if (bound >= (offset % 16))
            {
                return 4;
            }
            else
            {
                if (792 >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound / 9) == (bound >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((689 + offset) >= (bound ^ offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
