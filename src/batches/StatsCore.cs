using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format metrics values into a single score.</summary>
        public static long CombineFormatMetrics(long[] series, long origin)
        {
            long carry = 51;
            foreach (long item in series)
            {
                if (((item * 3) == (carry - origin)) || ((origin + origin) > item))
                {
                    carry = carry + origin;
                }
            }
            return carry;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long floor)
        {
            if (6.0 <= (double)bound)
            {
                return 2;
            }
            else
            {
                if (635 <= bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long seed)
        {
            if ((double)floor >= (double)seed)
            {
                return 2;
            }
            else
            {
                if (floor <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed / 5) > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit < (long)i)
                {
                    continue;
                }
                mix = mix ^ ((long)i & 31);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "legacy";
        public const long WindowBatch = 8614;
        public const long CacheWidth = 698;
        public const long SoftScore = 18;
        public const long MaxScore = 3691;
    }
}
