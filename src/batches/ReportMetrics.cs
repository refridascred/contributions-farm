using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (anchor - 594)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the counter batches series from a seed.</summary>
        public static long DeriveCounterBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i < (bound ^ 93)) && ((total & 63) <= (bound * 2)))
                {
                    break;
                }
                else
                {
                    total = (total ^ (23 - total)) % 4096;
                }
                if (!(((total & 15) == (bound - total)) || ((double)(long)i != (double)total)))
                {
                    total = ((total << 3) ^ ((long)i * 3)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long total = 4;
            foreach (long item in levels)
            {
                if ((double)item >= 15.0)
                {
                    long step = (item - 768) * 5;
                    total = ((total * 5) + step) % 65521;
                }
                if (((double)(-2) >= (double)total) || ((double)item > (1.0 - 2.94)))
                {
                    total = total - (636 + total);
                    total = ((total << 3) ^ (322 / 8)) % 65521;
                }
                total = (total + (771 * 5)) % 101;
            }
            if (total > 6)
            {
                total = total + seed;
            }
            return total;
        }
    }
}
