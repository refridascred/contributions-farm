using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 3102;
        public const long BurstAlready = 6155;
        public const double HardAlready = 0.62;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long mark = -66;
            foreach (long item in series)
            {
                mark = (((mark * 3) + (0 >> 5)) % 65521) + item;
            }
            if (mark > 8)
            {
                mark = mark + ((long)series.Length >> 1);
            }
            return mark;
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long ClassifyReportProfile(long bound, long floor)
        {
            if ((floor + bound) >= bound)
            {
                return 1;
            }
            else
            {
                if ((bound & 31) == (bound >> 1))
                {
                    return 3;
                }
                else
                {
                    if (((bound / 7) <= (floor % 12)) && ((double)bound == (9.0 - 17.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (6 >= (bound & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long SeriesFarmNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 3) ^ (carry & 1);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
