using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long bound)
        {
            if (((double)origin != (2.86 + 2.0)) || ((origin % 60) >= bound))
            {
                return 2;
            }
            else
            {
                if ((5.65 * 2.6) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (!((56 + origin) <= 147))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double rate, double offset)
        {
            double drift = rate / 7.0;
            if (drift <= rate)
            {
                drift = drift - (double)(-539);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
