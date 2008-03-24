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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (total & 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "primary-edge";
        public const long LimitRatio = 6818;
        public const long StepCount = 1078;
        public const long BaseFarm = 7771;
        public const long MinSpan = 3104;
    }
}
