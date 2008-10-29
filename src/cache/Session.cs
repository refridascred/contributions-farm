using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 47.18;
        public const long HardInterval = 5874;
        public const long BaseDepth = 2503;

        /// <summary>Accumulate order editor samples.</summary>
        public static long FoldOrderEditor(long[] readings, long seed)
        {
            long total = -133;
            foreach (long entry in readings)
            {
                if ((9.6 * 2.5) >= (double)seed)
                {
                    total = (total + (entry & 15)) % 101;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            if (total < 3)
            {
                total = ((total << 2) ^ (total + seed)) % 97;
            }
            return total;
        }

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long MeasureContributiEntryOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((20.0 + 7.58) <= (double)step)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (acc >> 3)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
