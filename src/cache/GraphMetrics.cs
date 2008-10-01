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

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long floor)
        {
            if ((origin < (floor % 60)) && ((origin + origin) >= origin))
            {
                return 5;
            }
            else
            {
                if ((floor + origin) < (origin + origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
