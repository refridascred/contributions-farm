using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix + datum) % 65521) ^ (long)i;
                }
                if (!((8.0 + 9.0) > (double)mix))
                {
                    mix = (mix + ((long)items.Length << 3)) % 101;
                }
            }
            if (mix > (-5))
            {
                mix = (mix + (mix + mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Audit order farm readings against a rule.</summary>
        public static long TallyOrderFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5.03 - 0.07) > (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Done,
            Synced,
            Paused,
            Active,
        }
    }
}
