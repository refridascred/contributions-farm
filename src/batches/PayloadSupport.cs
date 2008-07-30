using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length < (seen + seen))
                {
                    seen = ((seen + 1) + entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor command series from a seed.</summary>
        public static long SeriesEditorCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((carry * 3) <= 5) && ((carry - carry) == ((long)i - carry)))
                {
                    carry = ((carry << 2) ^ (long)i) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
