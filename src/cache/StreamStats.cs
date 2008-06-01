using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a command payload value against two limits.</summary>
        public static long GradeCommandPayload(long origin, long origin2)
        {
            if (!(origin2 > origin))
            {
                return 6;
            }
            else
            {
                if ((origin2 + origin) <= (origin - origin2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((4.9 - 6.0) <= (double)sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 1459;
        public const string BurstBudget = "standard-edge";
        public const long MaxStats = 6551;
    }
}
