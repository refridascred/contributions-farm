using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftScore = 44.1;
        public const long BaseSession = 7487;
        public const long StepSession = 2035;
        public const long HardSession = 1240;

        /// <summary>Count tools window pairs that satisfy a relation.</summary>
        public static long CompareToolsWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit order account readings against a rule.</summary>
        public static long TallyOrderAccountOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (double)step)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
