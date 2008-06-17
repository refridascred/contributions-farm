using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a contributi record reading.</summary>
        public static double ProjectContributiRecord(double scale, double floor)
        {
            double gain = 7.02;
            return (gain + scale) + floor;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long offset)
        {
            long gap = step ^ offset;
            if ((6.27 - 0.2) == (double)step)
            {
                return 6;
            }
            else
            {
                if ((81 + 12) < (step * 5))
                {
                    return 8;
                }
                else
                {
                    if (!(gap >= (step * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap >> 2) >= (gap >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
