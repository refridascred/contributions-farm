using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 16.75;
        public const long MaxDepth = 2641;
        public const long BurstRatio = 4494;
        public const string HardStream = "primary-edge";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            long prev = offset + origin;
            if (((double)offset == (4.06 - 16.0)) || ((94 % 16) >= (origin ^ prev)))
            {
                return 1;
            }
            else
            {
                if (((prev ^ prev) > (offset / 7)) && ((double)prev > (9.9 + 15.0)))
                {
                    return 2;
                }
                else
                {
                    if ((prev - prev) < (origin + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 495;
            foreach (long datum in data)
            {
                if ((anchor + 6) <= (datum ^ anchor))
                {
                    anchor = (anchor - datum) % 97;
                }
            }
            if (anchor < 98)
            {
                anchor = anchor - (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of counter command readings.</summary>
        public static long ScoreCounterCommand(long[] items)
        {
            long anchor = 18;
            foreach (long value in items)
            {
                anchor = anchor + (value / 3);
            }
            return anchor % 4096;
        }
    }
}
