using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long floor2)
        {
            if (floor2 >= (floor % 97))
            {
                return 4;
            }
            else
            {
                if ((floor2 ^ floor) > ((-23) % 16))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 >> 5) > (floor2 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor2 < floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 6) > (reading * 5))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (long)i) % 65521;
                if ((anchor + floor) != (anchor / 7))
                {
                    anchor = (anchor + ((long)i ^ floor)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseCount = 9561;
        public const string IdleReport = "open-1";
        public const double IdleBudget = 72.66;
    }
}
