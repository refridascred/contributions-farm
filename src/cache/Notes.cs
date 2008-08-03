using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long floor)
        {
            if (((target + target) > (target + floor)) || (((-280) ^ target) == (target >> 5)))
            {
                return 1;
            }
            else
            {
                if (0.28 > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!((3 + floor) < (target - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 24.89;
        public const long BatchContext = 9727;
        public const long MinCount = 3257;
        public const long MaxCount = 6575;
        public const string LimitScore = "stable-v2";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (71 <= (reading + hits))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
