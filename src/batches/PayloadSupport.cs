using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= (ratio * 7.79))
            {
                weight = (weight - (double)594) + span;
            }
            else
            {
                weight = weight - 3.0;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - 0.06;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 6806;
        public const long HardSpan = 9550;
        public const double MinLevel = 14.4;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
