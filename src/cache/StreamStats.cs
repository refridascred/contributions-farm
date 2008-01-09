using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long step2)
        {
            if (!(step > step2))
            {
                return 4;
            }
            else
            {
                if ((473 % 8) > step2)
                {
                    return 6;
                }
                else
                {
                    if (!((step2 % 3) > step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 / 6) == (4 + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 54.8;
        public const long IdleGraph = 15;
        public const long IdleSize = 3112;
        public const long BaseGraph = 494;
        public const long CacheSpan = 6007;

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 66.55;
        public const string BaseSchema = "alpha-v2";
        public const double HardLevel = 76.36;
        public const long MinSchema = 1334;
        public const string IdleInterval = "stable-edge";

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
