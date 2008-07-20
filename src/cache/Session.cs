using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + 83) == (cell & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 5788;
        public const long StepLayout = 4089;
        public const long DefaultWidth = 6068;
        public const string IdleLayout = "staging-v2";
        public const double BurstRatio = 72.78;

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample > (979 << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
