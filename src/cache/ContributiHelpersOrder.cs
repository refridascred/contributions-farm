using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long step2)
        {
            if (((10.0 - 9.58) == (double)step2) || (step <= step2))
            {
                return 2;
            }
            else
            {
                if ((step / 5) > 626)
                {
                    return 8;
                }
                else
                {
                    if (step <= (step / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.0 * 5.45) < (double)step) || ((double)step < 1.2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 67.74;
        public const long SoftRatio = 5268;
        public const long IdleTools = 8189;
    }
}
