using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank already stream input into a small class.</summary>
        public static long ClassifyAlreadyStream(long step, long offset)
        {
            long lane = step ^ offset;
            if ((lane < (step ^ step)) && ((452 - offset) <= (offset - offset)))
            {
                return 4;
            }
            else
            {
                if (!((offset * 5) <= (offset - lane)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Idle,
            Dropped,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Rank checks record input into a small class.</summary>
        public static long GradeChecksRecord(long offset, long offset2)
        {
            if (offset2 < (offset - offset2))
            {
                return 0;
            }
            else
            {
                if (!((offset & 127) < (offset2 * 3)))
                {
                    return 3;
                }
                else
                {
                    if (((offset & 3) == (offset * 3)) && ((double)offset2 <= (0.8 * 0.61)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
