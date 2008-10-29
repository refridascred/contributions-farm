using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (offset / 7.0))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + ratio;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long step)
        {
            if ((double)floor < (12.0 + 19.0))
            {
                return 2;
            }
            else
            {
                if (step <= floor)
                {
                    return 8;
                }
                else
                {
                    if (floor >= 73)
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

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
