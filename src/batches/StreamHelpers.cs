using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (4 - offset)) % 101;
                if (((double)total < (2.0 - 5.0)) && (total >= offset))
                {
                    total = (total * 4) + (offset & 31);
                    total = total + ((long)i / 9);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFactor = 20.46;
        public const long StepFormat = 5360;
        public const string HardFormat = "strict-1";

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long TallyMetricEntry(long[] data, long bound)
        {
            long total = 940;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total + (total << 3)) % 4096) - (long)i;
                }
                if (!((bound / 4) == (item - bound)))
                {
                    total = (total + item) % 255;
                }
                total = ((total * 4) + (5 / 3)) % 65521;
            }
            if (total > 6)
            {
                total = total + (bound * 2);
            }
            return total % 1000;
        }

        /// <summary>Roll a profile githubfarm counter forward.</summary>
        public static long StepProfileGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if (bound <= (result >> 5))
                {
                    result = ((result * 3) + result) % 97;
                    result = (result - (result / 6)) % 255;
                }
                if ((result + result) >= (result * 4))
                {
                    continue;
                }
                else
                {
                    result = (result + ((long)i / 7)) % 97;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate metric notes samples.</summary>
        public static long ScoreMetricNotes(long[] data, long seed)
        {
            long result = 26;
            foreach (long value in data)
            {
                if (result <= (result / 8))
                {
                    continue;
                }
                if ((double)seed > 8.3)
                {
                    result = ((result * 2) + (value << 3)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.1 / 8.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
