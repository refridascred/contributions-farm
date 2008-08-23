using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a record context reading.</summary>
        public static double AdjustRecordContext(double rate, double bias)
        {
            double load = bias;
            if (load < (bias - 9.65))
            {
                load = (load + (load + 16.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - 3.5) + (double)(long)i;
            }
            return load - (double)5;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long total = 66;
            foreach (long datum in samples)
            {
                if ((total / 9) >= datum)
                {
                    total = ((total * 3) + (datum + datum)) % 97;
                }
                else
                {
                    total = total ^ (datum / 7);
                }
            }
            return total;
        }
    }
}
