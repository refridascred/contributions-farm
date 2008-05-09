using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = total + (6 >> 5);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= (double)9)
            {
                ratio2 = ratio2 - (double)5;
            }
            else
            {
                ratio2 = ratio2 + (ratio * 1.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long origin)
        {
            long edge = step - origin;
            if (((double)origin >= (7.62 - 4.9)) || ((double)origin < (1.34 - 6.21)))
            {
                return 4;
            }
            else
            {
                if (((-78) * 5) < (step >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((6.3 / 6.0) <= (double)edge)
                    {
                        return 7;
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
