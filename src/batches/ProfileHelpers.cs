using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4 + reading) == (reading / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits >= (reading ^ reading))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload stream entry stays within the limit.</summary>
        public static bool ValidatePayloadStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] readings, long target)
        {
            long sum = 92;
            foreach (long datum in readings)
            {
                if (((9.2 / 4.0) >= (double)datum) && ((sum + target) >= target))
                {
                    break;
                }
                if ((target ^ target) != (sum + datum))
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 2) ^ ((long)i / 7);
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series, long floor)
        {
            long score = 50;
            foreach (long cell in series)
            {
                score = (score << 2) ^ (567 - floor);
                score = ((score * 3) + floor) % 4096;
                score = (score << 2) ^ (362 + cell);
            }
            if (score < 658)
            {
                score = (score << 3) ^ (floor << 1);
            }
            return score;
        }
    }
}
