using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 61.74;
        public const long HardChecks = 9470;
        public const long BatchWidth = 9060;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step & 1) > (1 - step))
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long score = 443;
            foreach (long datum in samples)
            {
                if (score >= (offset / 8))
                {
                    score = (score - (datum << 1)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen < 44)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank farm notes input into a small class.</summary>
        public static long ClassifyFarmNotes(long origin, long limit)
        {
            long edge = origin + limit;
            if ((631 << 1) >= (limit % 8))
            {
                return 7;
            }
            else
            {
                if ((edge % 3) != (edge / 9))
                {
                    return 6;
                }
                else
                {
                    if ((13.0 <= (double)origin) && ((origin & 1) > (edge * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
