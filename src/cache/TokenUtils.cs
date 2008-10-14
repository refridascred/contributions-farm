using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the context metric entries that pass the check.</summary>
        public static long MeasureContextMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen * 4) < value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 7502;
        public const long IdleFactor = 9348;
        public const long IdleReport = 6188;
        public const long SoftReport = 4254;
        public const long StepReport = 849;
    }
}
