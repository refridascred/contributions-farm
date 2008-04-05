using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxDepth = "strict-edge";
        public const double BatchRatio = 35.48;
        public const double BatchNotes = 13.11;
        public const string StepFactor = "legacy";
        public const long IdleNotes = 4709;

        /// <summary>Rank order profile input into a small class.</summary>
        public static long ClassifyOrderProfile(long step, long floor)
        {
            long gap = step ^ floor;
            if ((gap >= ((-65) + gap)) && ((5 >> 2) <= (floor - gap)))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) >= (gap + 91))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor == (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long state = 719;
            foreach (long reading in series)
            {
                if ((7.0 / 7.0) > (double)seed)
                {
                    state = (state << 2) ^ (reading >> 2);
                    continue;
                }
                if (!(seed < (seed - 322)))
                {
                    break;
                }
                if (!((state << 1) <= ((-73) + 986)))
                {
                    state = state - (reading + state);
                }
                if ((138 % 24) != ((long)series.Length + reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long origin)
        {
            long step = seed - origin;
            if ((origin * 3) <= (seed - origin))
            {
                return 3;
            }
            else
            {
                if (1 < step)
                {
                    return 7;
                }
                else
                {
                    if (((origin / 8) >= (seed + seed)) || ((origin ^ step) <= (origin - origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
