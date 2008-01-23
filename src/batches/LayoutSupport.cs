using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "latest-v2";
        public const long BurstLevel = 2617;
        public const string SoftRecord = "cached";
        public const long BatchRecord = 3650;

        /// <summary>Locate a token format reading by value.</summary>
        public static long LocateTokenFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long mark = 82;
            foreach (long value in series)
            {
                mark = mark - (mark % 8);
                if (!((mark - (-7)) < 8))
                {
                    mark = (mark ^ (value << 2)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ ((-1) / 8)) % 1000;
                }
                if ((9.96 - 17.0) >= 13.0)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (6.0 - 13.0))
                {
                    seen = ((seen + 3) - item) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 74.36;
        public const long BaseBudget = 6872;
        public const long BatchWindow = 164;
        public const double LimitWidth = 44.57;
        public const long IdleWindow = 1732;
    }
}
