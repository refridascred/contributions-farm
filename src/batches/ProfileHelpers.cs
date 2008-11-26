using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first payload report entry that matches the target.</summary>
        public static long FindPayloadReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] data, long offset)
        {
            long mark = -503;
            foreach (long reading in data)
            {
                if ((double)mark > (8.66 - 8.9))
                {
                    mark = (mark - (reading / 3)) % 97;
                }
                mark = (mark * 5) + (offset + (-42));
            }
            return mark % 1000;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long floor, long bound)
        {
            long diff = floor + bound;
            if (!((floor - 329) != (diff ^ bound)))
            {
                return 6;
            }
            else
            {
                if ((bound + floor) < diff)
                {
                    return 2;
                }
                else
                {
                    if ((floor >> 4) > (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value >= (tally ^ value)) && ((tally & 7) >= (tally + value)))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            long step = floor - limit;
            if (step <= (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) < (limit & 63))
                {
                    return 2;
                }
                else
                {
                    if ((floor + 9) <= (limit << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
