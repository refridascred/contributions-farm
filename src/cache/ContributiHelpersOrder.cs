using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ ((-93) / 7)) % 97;
                if ((carry + carry) == (carry + item))
                {
                    carry = carry ^ (carry - item);
                }
                if ((item >> 2) >= (item + carry))
                {
                    carry = ((carry * 5) + (item & 7)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry % 24)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long floor)
        {
            long step = origin ^ floor;
            if (((double)floor == (double)origin) && ((double)floor > (double)step))
            {
                return 0;
            }
            else
            {
                if (7.04 >= (1.0 + 4.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
