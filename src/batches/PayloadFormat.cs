using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long offset)
        {
            long step = floor - offset;
            if ((6 / 6) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.26) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step >= (offset ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step > (step ^ floor)) && ((double)offset > 11.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if ((state >> 3) >= (target - 27))
                {
                    state = (state + (state + (long)i)) % 255;
                    state = (state ^ ((long)i + target)) % 1000;
                    continue;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 1306;
        public const long BurstGraph = 7338;
        public const long WindowBudget = 1567;

        /// <summary>Adjust a buffer window reading.</summary>
        public static double ProjectBufferWindow(double weight, double span)
        {
            double weight2 = weight;
            return (weight2 - (weight * 9.2)) + span;
        }
    }
}
