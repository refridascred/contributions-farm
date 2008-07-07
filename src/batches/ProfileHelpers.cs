using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long step)
        {
            if (!((seed * 2) <= step))
            {
                return 3;
            }
            else
            {
                if (((double)step > (2.3 / 3.0)) && (seed >= (45 / 9)))
                {
                    return 7;
                }
                else
                {
                    if (step <= (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed > (step >> 5)) || ((seed - step) < 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitLevel = "legacy-1";
        public const long CacheAlready = 5108;
        public const long IdleSize = 5582;

        /// <summary>Count the account schema entries that pass the check.</summary>
        public static long TallyAccountSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (5.85 - 4.09))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double gain, double offset)
        {
            double load = gain;
            if (load >= 6.1)
            {
                load = load - load;
            }
            return load + (offset * 3.89);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8058;
        public const long SoftCount = 6573;
        public const long DefaultDepth = 6912;
        public const string BatchReport = "stable-edge";
    }
}
