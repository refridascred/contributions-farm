using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many stream entry samples are out of range.</summary>
        public static long MeasureStreamEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long seed)
        {
            long step = bound + seed;
            if ((step << 1) < (49 - seed))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (19.0 - 1.9))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > (seed >> 4)) && ((seed * 5) >= (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Combine stats farm values into a single score.</summary>
        public static long WeighStatsFarm(long[] levels, long floor)
        {
            long score = 151;
            foreach (long cell in levels)
            {
                if ((cell << 2) <= floor)
                {
                    score = (score << 2) ^ (floor ^ score);
                }
                else
                {
                    score = ((score * 3) + (score - 3)) % 4096;
                }
            }
            if (score > 46)
            {
                score = score + 78;
            }
            return score;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            New,
            Synced,
            Retry,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Stale,
            Closed,
        }
    }
}
