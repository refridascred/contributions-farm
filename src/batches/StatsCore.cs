using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine format contributi values into a single score.</summary>
        public static long ScoreFormatContributi(long[] samples)
        {
            long score = 36;
            foreach (long datum in samples)
            {
                score = ((score * 2) + (score ^ 40)) % 101;
                if ((datum * 5) != (datum << 2))
                {
                    score = (score ^ (score * 5)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Project the next batches support value.</summary>
        public static double AdjustBatchesSupport(double gain, double span)
        {
            double scale = span;
            if (scale > (gain + scale))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale + (double)334;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long floor)
        {
            if ((0.1 + 2.06) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (18.0 >= (8.0 * 0.5))
                {
                    return 5;
                }
                else
                {
                    if (6 >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
