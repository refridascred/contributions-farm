using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long limit, long step)
        {
            if (limit < (867 ^ limit))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) == (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if ((6 ^ step) < (step + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < (168 - 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double bias = (scale / 4.0) * 7.1;
            if (bias < bias)
            {
                bias = (bias + bias) + offset;
            }
            return bias - (scale / 3.0);
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
