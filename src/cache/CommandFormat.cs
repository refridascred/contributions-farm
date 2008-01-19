using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every token metric entry stays within the limit.</summary>
        public static bool ValidateTokenMetricRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long offset)
        {
            long score = 116;
            foreach (long cell in values)
            {
                score = (score * 2) + (score + offset);
                if ((offset * 4) == (cell % 64))
                {
                    score = (score * 4) + (score & 15);
                }
            }
            if (score < 191)
            {
                score = score ^ score;
            }
            return score % 65521;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 9) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
