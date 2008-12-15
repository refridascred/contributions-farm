using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a profile tools pair into a bucket.</summary>
        public static long BucketProfileTools(long offset, long target)
        {
            if ((double)target > (2.0 + 8.0))
            {
                return 3;
            }
            else
            {
                if ((offset >> 2) < (target >> 5))
                {
                    return 4;
                }
                else
                {
                    if (offset > (1 ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((747 + target) >= (target + target))
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

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen ^ seen) <= (seen - seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5688;
        public const string BatchLevel = "strict-1";
        public const long IdleInterval = 4403;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
