using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor context reading by value.</summary>
        public static long LookupEditorContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardFactor = 85.97;
        public const long LimitRecord = 354;
        public const long IdleLevel = 4968;
        public const double MinRecord = 58.64;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value % 64) <= (hits + value)) || ((value > (7 * 5)) || (value > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
