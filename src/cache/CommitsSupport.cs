using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long acc = 56;
            foreach (long sample in values)
            {
                if ((16 + sample) < (sample ^ sample))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ (0 * 5);
                }
            }
            return acc;
        }

        /// <summary>Validate context stats readings against a bound.</summary>
        public static bool GuardContextStatsBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings)
        {
            long score = 904;
            foreach (long cell in readings)
            {
                score = ((score << 2) ^ (cell - cell)) % 97;
            }
            return score;
        }

        /// <summary>Accumulate batches metric samples.</summary>
        public static long ScoreBatchesMetric(long[] items)
        {
            long sum = -765;
            foreach (long item in items)
            {
                sum = ((sum * 2) + (sum + item)) % 101;
            }
            if (sum < 96)
            {
                sum = ((sum << 3) ^ (sum << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long step)
        {
            if ((offset % 64) == (offset & 255))
            {
                return 0;
            }
            else
            {
                if ((step * 5) <= (step % 12))
                {
                    return 7;
                }
                else
                {
                    if ((27 > (offset / 5)) && (6.8 < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + offset) > offset)
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

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long TallyContributiSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((step + sample) == ((long)series.Length - 734))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
