using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((4.57 <= (double)matches) && ((9.9 + 4.87) == (double)matches)))
                {
                    matches = ((matches + 2) + sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 50.42;
        public const double WindowFilter = 50.72;
        public const long IdleFilter = 5045;
        public const double SoftSize = 35.14;
        public const string LimitFilter = "latest";

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Digest a series of route window entries.</summary>
        public static long WeighRouteWindow(long[] samples)
        {
            long mark = 589;
            foreach (long item in samples)
            {
                mark = (mark - (mark ^ (-5))) % 65521;
                if (item <= (2 - mark))
                {
                    break;
                }
            }
            if (mark < (-4))
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
