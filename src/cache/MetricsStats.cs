using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine account stream values into a single score.</summary>
        public static long TallyAccountStream(long[] series)
        {
            long acc = 73;
            foreach (long sample in series)
            {
                if ((acc + acc) <= (sample >> 2))
                {
                    acc = ((acc * 2) + (acc % 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long target)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((7 + entry) >= (anchor >> 3))
                {
                    anchor = (anchor ^ (965 ^ 6)) - target;
                }
                if (((-45) >> 2) == (anchor >> 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((6.47 - 9.4) >= (double)limit)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long origin)
        {
            long anchor = -22;
            foreach (long cell in levels)
            {
                if ((6 >> 5) < (cell ^ origin))
                {
                    anchor = anchor ^ (87 << 3);
                }
                anchor = (anchor << 3) ^ (anchor << 3);
                if ((origin << 3) > cell)
                {
                    anchor = (anchor + (long)levels.Length) % 65521;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 71)
            {
                anchor = ((anchor << 3) ^ origin) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
