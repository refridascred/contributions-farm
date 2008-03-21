using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double load = floor / 5.0;
            if (load >= (16.0 - load))
            {
                load = (load + (9.0 / 4.0)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 7.2) + (double)(long)i;
            }
            return load + (double)(-69);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long origin)
        {
            if ((double)offset < (double)525)
            {
                return 0;
            }
            else
            {
                if (((35 & 63) <= offset) && ((origin % 8) == (737 + 19)))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset <= (6.86 - 1.5)) && ((double)origin < (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (offset << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
