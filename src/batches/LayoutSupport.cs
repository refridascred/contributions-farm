using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats profile samples.</summary>
        public static long WeighStatsProfile(long[] series, long limit)
        {
            long score = 679;
            foreach (long sample in series)
            {
                if ((5.4 * 7.5) >= (double)sample)
                {
                    score = (score ^ (score % 8)) % 65521;
                }
                else
                {
                    score = (score + (274 / 7)) % 4096;
                }
                if (score < 1)
                {
                    score = score ^ (limit + limit);
                }
            }
            return score % 97;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
