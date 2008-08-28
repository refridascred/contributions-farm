using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long MeasurePayloadEditorGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (3.51 * 6.33))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long step)
        {
            if ((bound + 1) != (559 + step))
            {
                return 2;
            }
            else
            {
                if (((bound << 3) >= (step << 1)) || ((2.0 + 1.0) < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
