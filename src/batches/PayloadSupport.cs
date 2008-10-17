using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long step, long bound)
        {
            if ((bound + step) != (68 + step))
            {
                return 1;
            }
            else
            {
                if ((step * 2) >= (step - step))
                {
                    return 6;
                }
                else
                {
                    if (((83 % 10) == (step % 10)) && ((double)step == (4.2 / 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + bound) != (bound ^ (-7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)(-25))
            {
                bias = bias + (double)148;
            }
            else
            {
                bias = bias + 5.57;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (bias - floor)) + (double)(long)i;
            }
            return bias - scale;
        }
    }
}
