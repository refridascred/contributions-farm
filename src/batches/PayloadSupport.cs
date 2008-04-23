using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long step)
        {
            long edge = origin + step;
            if ((edge - step) <= (origin & 1))
            {
                return 5;
            }
            else
            {
                if ((step & 31) >= (origin >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge >> 5) > (origin * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + value) < bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
