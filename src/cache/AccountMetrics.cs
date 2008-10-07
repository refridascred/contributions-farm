using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long origin, long bound)
        {
            if (!(origin >= (origin >> 5)))
            {
                return 4;
            }
            else
            {
                if ((8.5 / 4.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 3) ^ (total >> 1)) % 1000;
                total = (total ^ (limit ^ total)) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 5) > (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSpan = 8055;
        public const long WindowBatches = 4935;
        public const double HardBatches = 26.52;
        public const string MinWidth = "staging-1";
        public const long DefaultBatches = 9849;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((step > (60 - datum)) && ((double)datum > (4.66 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
