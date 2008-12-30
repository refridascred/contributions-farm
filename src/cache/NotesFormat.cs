using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long target2)
        {
            long edge = target + target2;
            if ((edge ^ target2) > (edge - edge))
            {
                return 5;
            }
            else
            {
                if ((double)target2 != (0.6 * 5.6))
                {
                    return 0;
                }
                else
                {
                    if (!((5 ^ target) >= (91 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 < (target & 31)) && ((16.0 + 7.27) != (double)target2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardInterval = 9266;
        public const long BaseReport = 2089;
        public const long StepReport = 8146;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
