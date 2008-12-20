using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long origin)
        {
            long step = target ^ origin;
            if (3 > step)
            {
                return 2;
            }
            else
            {
                if (((double)target <= (7.0 * 1.0)) || ((double)target == (4.3 - 1.2)))
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin > (1.21 / 6.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double rate = floor + bias;
            return rate - (rate - 6.5);
        }
    }
}
