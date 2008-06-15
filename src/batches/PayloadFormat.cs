using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long limit)
        {
            long cur = step + limit;
            if (((cur - 2) <= (cur + cur)) && ((double)step == (9.0 + 7.94)))
            {
                return 4;
            }
            else
            {
                if (((1 + step) > (limit % 5)) && ((43 << 2) <= (cur & 127)))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= 5.3) && ((limit - limit) > (step / 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.0 <= (double)limit) || ((step + cur) > (step - limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ 6) < (floor - floor))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double weight = bias;
            if (weight <= offset)
            {
                weight = weight - (offset + weight);
            }
            else
            {
                weight = weight - (bias / 5.0);
            }
            return weight + offset;
        }
    }
}
