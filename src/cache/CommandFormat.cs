using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = 54;
            foreach (long entry in data)
            {
                anchor = (anchor ^ 97) ^ entry;
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((2.1 * 20.0) <= (double)matches) && (((cell + matches) != (0 ^ floor)) && ((2.56 / 4.0) < (double)cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate editor buffer readings against a bound.</summary>
        public static bool GuardEditorBufferBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen >> 5) <= (seen & 3))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
