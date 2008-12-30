using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double bias)
        {
            double weight = ratio - (bias * 5.5);
            return weight + (double)958;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a counter profile value against two limits.</summary>
        public static long GradeCounterProfile(long floor, long step)
        {
            long delta = floor ^ step;
            if (((0.2 - 9.0) == (double)floor) && (step > (delta - floor)))
            {
                return 3;
            }
            else
            {
                if (floor <= (delta - floor))
                {
                    return 1;
                }
                else
                {
                    if (52 > (delta ^ step))
                    {
                        return 0;
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
