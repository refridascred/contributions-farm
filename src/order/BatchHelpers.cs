using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up contributi stats samples.</summary>
        public static long PairContributiStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Count contributi channel pairs that satisfy a relation.</summary>
        public static long PairContributiChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
