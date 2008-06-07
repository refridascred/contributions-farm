using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two tools token measurements.</summary>
        public static double ScaleToolsToken(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 3.37) - (double)(long)i) - floor;
            }
            return load - (load * 5.44);
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate channel stream readings against a bound.</summary>
        public static bool GuardChannelStreamLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double weight = (double)(2 + 2);
            if (weight >= gain)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (gain + 0.3);
        }
    }
}
