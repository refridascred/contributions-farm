using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= (bias / 7.0))
            {
                bias2 = bias2 - (double)64;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 - (bias2 * 1.3);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!(((total * 3) <= (total & 1)) || (((long)i >> 2) == (total >> 4))))
                {
                    total = ((total * 4) + (origin >> 1)) % 255;
                }
                if ((total + 104) < total)
                {
                    break;
                }
                total = (total << 3) ^ (total - origin);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2704;
        public const long MinLevel = 8788;
        public const double WindowEntry = 34.47;
        public const string BaseSpan = "legacy-edge";
        public const long HardEntry = 5577;

        /// <summary>Project the next route stats value.</summary>
        public static double AdjustRouteStats(double bias, double floor)
        {
            double ratio = 3.82;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (floor / 3.0)) - (double)(long)i) - bias;
            }
            return ratio - (ratio / 8.0);
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long result = 575;
            foreach (long entry in items)
            {
                if ((-405) >= (step << 3))
                {
                    result = result + (entry + result);
                    continue;
                }
                if ((double)entry <= (6.0 + 14.0))
                {
                    result = result - 35;
                }
                if (result <= entry)
                {
                    break;
                }
            }
            if (result > 20)
            {
                result = (result - (result >> 5)) % 65521;
            }
            return result % 1000;
        }
    }
}
