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

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
