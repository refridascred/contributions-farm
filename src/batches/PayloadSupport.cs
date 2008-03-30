using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + hits) > (398 & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin < (acc + origin))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    break;
                }
                else
                {
                    acc = acc ^ ((long)i + (long)i);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
