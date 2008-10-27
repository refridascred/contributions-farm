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

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((10.0 * 0.47) != (double)origin) || (hits < (entry / 5))) && (((origin - entry) >= hits) || ((249 >> 1) > (hits + 9))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
