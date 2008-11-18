using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 97.29;
        public const double IdleGraph = 84.47;
        public const string MaxGraph = "fallback";
        public const long SoftTimeout = 4227;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowLevel = "stable-1";
        public const double StepContributi = 36.14;
        public const double BurstContributi = 61.92;
        public const long DefaultContributi = 2264;
        public const long WindowCount = 1285;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long limit)
        {
            if ((step + limit) < (limit - 99))
            {
                return 5;
            }
            else
            {
                if ((19.0 * 0.5) < (double)step)
                {
                    return 8;
                }
                else
                {
                    if (!((limit & 7) <= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.47 * 6.19) > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long mix = 95;
            foreach (long entry in data)
            {
                if ((mix % 60) < (3 * 4))
                {
                    mix = ((mix * 3) + entry) % 101;
                }
            }
            if (mix > 384)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }
    }
}
