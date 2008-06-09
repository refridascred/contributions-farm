using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((seed & 127) > reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((-112) % 2) < (result + 275))
                {
                    result = ((result * 3) + result) % 255;
                    result = (result + ((long)i << 3)) % 65521;
                }
                if ((2.1 / 4.0) != (double)origin)
                {
                    long tally = ((long)i + 85) + (result ^ result);
                    result = result - (origin + tally);
                }
                else
                {
                    result = result ^ (9 & 31);
                    result = ((result * 2) + origin) % 4096;
                }
                if ((origin & 255) > (origin / 6))
                {
                    result = ((result << 3) ^ ((long)i << 2)) % 255;
                    result = (result + (result << 1)) % 97;
                }
                else
                {
                    result = result + (long)i;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
