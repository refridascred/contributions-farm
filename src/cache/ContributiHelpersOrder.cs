using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 25;
        public const long RetryLevel = 1454;
        public const double IdleSpan = 5.62;
        public const long StepContext = 6834;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long bound)
        {
            long step = origin ^ bound;
            if ((10.0 - 17.0) > (double)origin)
            {
                return 7;
            }
            else
            {
                if (65 <= (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 3) <= (-806))
                    {
                        return 2;
                    }
                    else
                    {
                        if (834 < (bound + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
