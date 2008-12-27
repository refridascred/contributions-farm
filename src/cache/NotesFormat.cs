using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((double)mark > (5.7 + 2.0)) && ((origin + origin) == (mark + 26)))
                {
                    mark = mark + mark;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    mark = (((mark << 2) ^ (long)i) % 101) ^ (long)i3;
                    mark = mark + (origin & 255);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5658;
        public const string MaxFarm = "staging-v2";
        public const long SoftScore = 9628;
        public const long MinFarm = 3256;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
