using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long step)
        {
            long lane = limit - step;
            if ((1.43 / 6.0) > (double)limit)
            {
                return 8;
            }
            else
            {
                if (((limit << 3) == (limit - step)) || ((lane * 4) == (limit ^ step)))
                {
                    return 4;
                }
                else
                {
                    if (((double)step >= (3.0 - 11.0)) && ((lane + 5) == (lane + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Paused,
            Dropped,
            Done,
        }
    }
}
