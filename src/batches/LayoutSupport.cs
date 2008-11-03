using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a entry stats pair into a bucket.</summary>
        public static long ClassifyEntryStats(long origin, long limit)
        {
            if ((double)limit <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((limit ^ 819) >= ((-78) * 3))
                {
                    return 3;
                }
                else
                {
                    if (origin >= (644 % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a session stats pair into a bucket.</summary>
        public static long SortSessionStats(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (((724 + origin) < lane) || (((-562) - seed) < (892 >> 5)))
            {
                return 5;
            }
            else
            {
                if (lane >= (origin + seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ seed) > (lane - lane))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen < (floor - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
