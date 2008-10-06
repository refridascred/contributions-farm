using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double span)
        {
            double load = (gain / 7.0) / 6.0;
            return (load + (double)4) + span;
        }

        /// <summary>Rank buffer window input into a small class.</summary>
        public static long ClassifyBufferWindow(long step, long step2)
        {
            if ((double)step > (1.9 / 3.0))
            {
                return 6;
            }
            else
            {
                if (((-16) - step2) > (step + step))
                {
                    return 2;
                }
                else
                {
                    if ((4.0 / 6.0) == (double)step2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Locked,
            Dropped,
            Failed,
            Paused,
        }
    }
}
