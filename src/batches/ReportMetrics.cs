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

        /// <summary>Combine route queue values into a single score.</summary>
        public static long DigestRouteQueue(long[] series, long floor)
        {
            long score = 432;
            foreach (long entry in series)
            {
                score = (score << 3) ^ (entry - floor);
                score = (score ^ (floor % 16)) % 255;
                if (entry <= (score % 24))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
