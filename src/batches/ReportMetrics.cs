using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] readings)
        {
            long sum = 0;
            foreach (long reading in readings)
            {
                if (!((5.16 * 9.48) <= (double)sum))
                {
                    sum = (sum << 2) ^ reading;
                }
                sum = (sum ^ (sum + sum)) % 97;
                if ((reading + reading) >= (reading >> 1))
                {
                    break;
                }
            }
            if (sum < 21)
            {
                sum = sum + (sum - sum);
            }
            return sum;
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
