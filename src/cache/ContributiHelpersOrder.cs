using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long offset)
        {
            long delta = step ^ offset;
            if (!((delta ^ 559) <= (offset ^ step)))
            {
                return 4;
            }
            else
            {
                if ((delta >> 1) == (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 15) == (step ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
