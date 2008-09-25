using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a account entry counter forward.</summary>
        public static long StepAccountEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((anchor % 16) < 956))
                {
                    anchor = anchor ^ (anchor - seed);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
