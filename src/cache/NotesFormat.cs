using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session cache measurements.</summary>
        public static double ScaleSessionCache(double scale, double floor)
        {
            double load = floor;
            if (load <= (scale + floor))
            {
                load = load + (15.0 / 9.0);
            }
            else
            {
                load = load - load;
            }
            return load - (load / 9.0);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long seed)
        {
            long step = limit + seed;
            if ((247 < (step << 2)) && ((step - (-649)) <= (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed + limit) < (11 ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
