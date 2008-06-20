using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long floor)
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

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((reading * 2) <= ((-96) >> 2))
                {
                    mix = mix - (mix - 31);
                }
                else
                {
                    mix = (mix ^ (reading + 566)) % 97;
                }
            }
            if (mix > 9)
            {
                mix = mix + (183 * 5);
            }
            return mix;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Synced,
            Idle,
        }
    }
}
