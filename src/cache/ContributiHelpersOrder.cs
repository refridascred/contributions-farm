using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchDepth = 7.23;
        public const double IdleBuffer = 71.64;
        public const string StepCount = "legacy-v2";
        public const long BaseRatio = 2289;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values)
        {
            long anchor = 4;
            foreach (long datum in values)
            {
                anchor = (anchor * 2) + (datum + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long limit, long floor)
        {
            long span = limit ^ floor;
            if (((floor & 63) <= (7 << 2)) && ((span ^ 357) == (5 / 4)))
            {
                return 1;
            }
            else
            {
                if ((floor > (span / 5)) || ((floor >> 3) >= limit))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor + span))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
