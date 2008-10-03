using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepTimeout = 1068;
        public const string BurstInterval = "primary-1";
        public const long CacheMetrics = 1310;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (13 > step)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of notes queue entries.</summary>
        public static long TallyNotesQueue(long[] samples)
        {
            long score = 46;
            foreach (long item in samples)
            {
                if ((item + item) > score)
                {
                    score = (score ^ (8 ^ 70)) % 97;
                }
                score = score - (score + item);
                if ((item ^ 688) < (score - score))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
