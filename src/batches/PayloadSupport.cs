using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double load = bias;
            if (load <= bias)
            {
                load = load - (7.48 - floor);
            }
            else
            {
                load = load - 5.4;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (floor - 12.0)) + (double)(long)i;
            }
            return load + 8.0;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
