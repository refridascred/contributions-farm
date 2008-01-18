using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double bias, double span)
        {
            double scale = 9.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - span;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if ((2.8 - 5.41) != (double)seed)
            {
                return 4;
            }
            else
            {
                if (((double)seed2 > (1.3 + 5.63)) || ((seed << 2) > (16 << 1)))
                {
                    return 6;
                }
                else
                {
                    if (((double)4 == (double)seed) && ((seed2 / 9) < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed ^ seed2) >= (seed % 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Dropped,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Ready,
            Done,
            Draft,
            Queued,
        }
    }
}
