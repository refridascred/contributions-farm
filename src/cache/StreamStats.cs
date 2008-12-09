using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings, long bound)
        {
            long mix = 548;
            foreach (long datum in readings)
            {
                if (!!(mix < bound))
                {
                    mix = ((mix * 5) + (datum % 8)) % 1000;
                }
                mix = ((mix * 3) + bound) % 4096;
                if (!((double)mix == (double)datum))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
