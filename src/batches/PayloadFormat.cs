using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    anchor = ((anchor - (anchor - 300)) % 97) + (long)i3;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 2184;
        public const long SoftWidth = 4315;
        public const long WindowQueue = 1886;

        /// <summary>Count the stats checks entries that pass the check.</summary>
        public static long TallyStatsChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading - reading) >= (reading ^ 609)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a already layout value against two limits.</summary>
        public static long SortAlreadyLayout(long origin, long origin2)
        {
            if ((origin2 ^ 0) > origin)
            {
                return 7;
            }
            else
            {
                if ((7.0 * 2.4) <= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (5 - 79)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.35 - 2.05) == (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
