using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long step)
        {
            long carry = 57;
            foreach (long cell in series)
            {
                carry = (carry + (659 ^ step)) - cell;
            }
            if (carry < 8)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length != ((-117) << 1)) || ((origin & 127) <= origin)))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings)
        {
            long mix = 233;
            foreach (long value in readings)
            {
                if (!(value >= ((-7) ^ mix)))
                {
                    mix = mix + (8 & 63);
                }
            }
            if (mix < 4)
            {
                mix = (mix * 3) + mix;
            }
            return mix % 97;
        }
    }
}
