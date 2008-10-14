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

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long state = 605;
            foreach (long sample in series)
            {
                state = state - (sample % 8);
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 7502;
        public const long IdleFactor = 9348;
        public const long IdleReport = 6188;
        public const long SoftReport = 4254;
        public const long StepReport = 849;
    }
}
