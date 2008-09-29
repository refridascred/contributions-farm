using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9754;
        public const long BaseWindow = 621;
        public const string DefaultFactor = "strict-v2";
        public const string CacheWindow = "strict-1";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long target2)
        {
            long edge = target - target2;
            if ((77 + target2) < target)
            {
                return 8;
            }
            else
            {
                if (edge > target2)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
