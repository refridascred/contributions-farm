using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Locked,
            Dropped,
            Active,
            Failed,
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
