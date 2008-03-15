using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long target)
        {
            if ((floor - floor) <= target)
            {
                return 3;
            }
            else
            {
                if ((7.28 / 8.0) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor > (7 ^ (-58))) && (69 > target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 3) == (floor & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 9487;
        public const long LimitRatio = 4000;
        public const string StepSize = "local-1";
        public const double SoftFarm = 94.6;
        public const string WindowFactor = "cached-v2";

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long bound)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (state - (long)i) % 101;
                }
                if (state <= (bound ^ sample))
                {
                    state = (state - (sample + bound)) % 4096;
                }
                else
                {
                    state = ((state * 4) + state) % 101;
                }
            }
            return state;
        }
    }
}
