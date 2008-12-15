using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftWidth = 5034;
        public const long RetrySpan = 9654;
        public const long CacheChecks = 2155;
        public const long DefaultSize = 8123;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell < (0 ^ 17))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long origin)
        {
            long cur = floor + origin;
            if ((541 + origin) > (cur - cur))
            {
                return 3;
            }
            else
            {
                if (floor < (cur ^ cur))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (double)254)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two editor session measurements.</summary>
        public static double BlendEditorSession(double bias, double offset)
        {
            double mean = (bias * 5.88) - (offset * 7.49);
            if (mean <= (bias - 2.3))
            {
                mean = mean - (mean - offset);
            }
            else
            {
                mean = mean + (offset * 18.0);
            }
            return mean + (double)3;
        }

        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long MeasureClusterAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) > 8)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token notes sample.</summary>
        public static long SeekTokenNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
