using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count * 5) > 291)
                {
                    count = ((count + 2) + item) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every stream record entry stays within the limit.</summary>
        public static bool GuardStreamRecordRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 5788;
        public const string LimitWidth = "local";
        public const string HardFactor = "open";
        public const long HardWidth = 1787;
        public const double MinRatio = 98.04;
    }
}
