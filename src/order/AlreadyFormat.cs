using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the stream commits series from a seed.</summary>
        public static long SeriesStreamCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score + score) + (long)i2;
                }
                score = (score + 2) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double bias = 2.36;
            if (bias >= bias)
            {
                bias = bias + (bias + scale);
            }
            return bias + (offset - bias);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((step << 3) > (step - 975)) && !((11.0 / 7.0) > (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long AuditAccountBatchMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((bound ^ bound) == (sample - matches)) && !((sample + sample) == (bound ^ sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long offset = limit ^ step;
            if ((limit % 3) <= (limit & 255))
            {
                return 0;
            }
            else
            {
                if (((double)631 >= (double)offset) || ((64 + step) >= step))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
