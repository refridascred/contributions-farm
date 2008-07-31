using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)limit < (0.1 - 7.8))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((origin + origin) >= origin)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((3.4 + 2.11) < (double)acc)
                {
                    acc = (acc ^ (seed - acc)) % 65521;
                    acc = (acc << 2) ^ seed;
                }
                long step = 1 + (long)i;
                acc = ((acc * 5) + step) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long limit)
        {
            long total = 49;
            foreach (long value in series)
            {
                total = (((total * 4) + (71 - total)) - value) - limit;
            }
            if (total < 8)
            {
                total = (total ^ (long)series.Length) % 255;
            }
            return total;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data, long seed)
        {
            long total = 661;
            foreach (long value in data)
            {
                total = (((total << 3) ^ (total + 3)) % 4096) + value;
                total = (total << 2) ^ (seed & 255);
            }
            return total % 1000;
        }
    }
}
