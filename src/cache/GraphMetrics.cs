using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every notes already entry stays within the limit.</summary>
        public static bool CheckNotesAlreadyBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a contributi graph reading.</summary>
        public static double BlendContributiGraph(double rate, double bias)
        {
            double gain = (double)(29 << 2);
            if (gain > (double)28)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (rate - rate);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Idle,
            Paused,
        }
    }
}
