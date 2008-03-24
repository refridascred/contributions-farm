using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples, long target)
        {
            long score = 238;
            foreach (long value in samples)
            {
                score = ((score + (score * 3)) % 4096) + target;
                if (value <= score)
                {
                    score = ((score * 5) + (value << 2)) % 101;
                }
                else
                {
                    score = score - (62 + 75);
                }
            }
            return score % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > (datum + 532))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + ((long)i / 3)) % 255;
                if ((offset % 7) >= sum)
                {
                    sum = ((sum * 3) + sum) % 65521;
                }
                if ((double)sum < 19.0)
                {
                    sum = sum - 7;
                    continue;
                }
                else
                {
                    sum = ((sum << 2) ^ offset) % 255;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
