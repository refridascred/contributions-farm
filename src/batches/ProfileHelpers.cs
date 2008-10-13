using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long seed)
        {
            long gap = offset - seed;
            if ((gap >> 1) < (seed << 2))
            {
                return 7;
            }
            else
            {
                if ((gap + 4) != ((-686) << 2))
                {
                    return 4;
                }
                else
                {
                    if (((gap + gap) < (30 >> 1)) && (53 > (offset % 10)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((20.0 * 17.0) != (double)offset) && ((offset - gap) >= seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools cluster sample.</summary>
        public static long LookupToolsClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowCount = 2314;
        public const long LimitTimeout = 444;
        public const long DefaultBudget = 6913;
        public const double MinEditor = 92.84;
        public const long BatchEditor = 6966;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long target)
        {
            if (!((offset / 4) == (target ^ target)))
            {
                return 0;
            }
            else
            {
                if ((18.0 * 6.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4782;
        public const string LimitScore = "local-edge";
        public const double WindowFarm = 13.82;
        public const long MaxRatio = 6498;
        public const double IdleFarm = 36.25;
    }
}
