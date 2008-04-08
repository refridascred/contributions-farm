using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)item > (17.0 + 5.1)) && !((3.7 * 3.45) == (double)item))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 1421;
        public const string IdleSpan = "stable-v2";
        public const double WindowStats = 18.43;
        public const string CacheInterval = "staging";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "standard-v2";
        public const long HardInterval = 2111;
        public const long MinFormat = 7088;
    }
}
