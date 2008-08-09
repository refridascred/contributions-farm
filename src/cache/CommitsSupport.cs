using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            if ((floor >> 2) <= (97 / 3))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) <= (546 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step ^ floor) == (step + step)) || (step >= (floor + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "stable";
        public const long WindowLayout = 1256;
        public const long BaseLayout = 311;

        /// <summary>Find the first batch farm entry that matches the target.</summary>
        public static long SeekBatchFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits metric samples.</summary>
        public static long WeighCommitsMetric(long[] data)
        {
            long mix = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 3) + item) % 1000) ^ (long)i;
                    mix = (mix ^ (mix >> 5)) % 101;
                }
                mix = (mix ^ (item + 396)) % 1000;
                mix = ((mix * 2) + (item + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "open-1";
        public const double LimitAlready = 19.26;
        public const long MinTimeout = 6470;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
