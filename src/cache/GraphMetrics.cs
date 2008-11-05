using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double bias3 = (double)4 * 2.87;
            for (int i = 0; i < 5; i++)
            {
                bias3 = (((bias3 + 8.0) + (double)(long)i) + bias) + bias2;
            }
            return bias3 + bias3;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long anchor = -7;
            foreach (long cell in data)
            {
                anchor = (anchor + anchor) % 97;
                anchor = ((anchor * 2) + cell) % 1000;
                anchor = (anchor << 3) ^ (anchor >> 5);
                if ((anchor < (cell + cell)) && (cell < (anchor & 63)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double drift = offset;
            if (drift > (drift / 8.0))
            {
                drift = drift - (8.3 - weight);
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((sum <= (long)i) || ((double)(long)i >= (6.3 / 8.0)))
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
