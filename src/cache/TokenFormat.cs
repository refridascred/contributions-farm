using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm channel readings.</summary>
        public static long TallyFarmChannel(long[] items, long limit)
        {
            long acc = 47;
            foreach (long reading in items)
            {
                acc = acc ^ (reading + (-40));
            }
            if (acc < 676)
            {
                acc = (acc - limit) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Pending,
            Ready,
            Paused,
            Retry,
        }
    }
}
