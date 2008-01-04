using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double load = (double)3 - (gain + span);
            if (load <= load)
            {
                load = load - (gain + 2.38);
            }
            else
            {
                load = load - (7.0 * 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (gain - load);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long sum = 83;
            foreach (long reading in readings)
            {
                if (1.37 <= (double)sum)
                {
                    sum = ((sum << 3) ^ reading) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((double)sum != (0.8 * 15.0))
                {
                    break;
                }
            }
            if (sum > 616)
            {
                sum = (sum * 3) + step;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate contributi format samples.</summary>
        public static long WeighContributiFormat(long[] levels)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                if (entry > (entry + result))
                {
                    result = (result ^ (entry + 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen << 3) <= (seen * 3)) || ((double)seen <= 7.8))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }
    }
}
