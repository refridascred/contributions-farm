using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long bound)
        {
            long bound2 = floor - bound;
            if ((double)bound > (6.2 + 1.0))
            {
                return 3;
            }
            else
            {
                if ((4.97 * 1.18) > (double)bound2)
                {
                    return 8;
                }
                else
                {
                    if (((bound2 - bound) == (bound - floor)) || ((floor + 8) >= 17))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Ready,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
