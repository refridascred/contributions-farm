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

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double scale = (bias * 8.0) + bias;
            if (scale < bias)
            {
                scale = (scale - 6.0) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - bias;
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
