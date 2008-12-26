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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((4.7 / 3.0) > (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches contributi sample.</summary>
        public static long FindBatchesContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 86.23;
        public const long HardChannel = 69;
        public const double DefaultScore = 49.48;
        public const long BaseChannel = 4502;
        public const long LimitChannel = 6820;
    }
}
