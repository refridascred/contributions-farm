using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4549;
        public const long BaseFilter = 8428;
        public const long WindowFilter = 7804;
        public const long LimitWidth = 5897;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 7666;
        public const string MinChecks = "staging";
        public const long DefaultChecks = 1312;
        public const string BurstChecks = "alpha-v2";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (seed >= (value & 31))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
