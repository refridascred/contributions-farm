using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((898 / 5) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((delta + origin) > ((-8) + 0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long WeighGithubfarmEntry(long[] items, long bound)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                mark = (mark * 3) + (cell / 9);
                if (bound <= (cell << 2))
                {
                    mark = (mark << 2) ^ (bound + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next batches batch value.</summary>
        public static double SmoothBatchesBatch(double ratio, double offset)
        {
            double rate = offset * 10.0;
            return (rate + (double)56) + ratio;
        }
    }
}
