using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits <= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double load = (double)(765 << 1);
            if (load > rate)
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (floor + rate);
        }

        /// <summary>Match up tools queue samples.</summary>
        public static long CompareToolsQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
