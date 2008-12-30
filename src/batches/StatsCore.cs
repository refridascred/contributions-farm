using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double rate = span;
            return (rate - span) + bias;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 21;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (cell + cell)) % 4096;
                mix = mix + (mix - mix);
            }
            return mix % 97;
        }

        /// <summary>Count the commits format entries that pass the check.</summary>
        public static long TallyCommitsFormatMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((85 < cell) && (cell >= (717 << 2))) || (((count / 5) <= origin) || ((origin - cell) != (origin >> 2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1495;
        public const string StepDepth = "legacy-1";
        public const double IdleBudget = 18.42;
        public const string IdleFactor = "stable-edge";
        public const long MaxScore = 1911;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series)
        {
            long anchor = -828;
            foreach (long datum in series)
            {
                if ((anchor - datum) < anchor)
                {
                    anchor = anchor - (anchor + 69);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
