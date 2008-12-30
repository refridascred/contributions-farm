using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool GuardEditorReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long step)
        {
            long gap = seed - step;
            if ((seed / 4) == (5 + gap))
            {
                return 5;
            }
            else
            {
                if ((double)gap <= (9.82 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if (((2 + gap) <= (7 & 3)) || ((double)seed > 6.3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.0 > (double)gap)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
