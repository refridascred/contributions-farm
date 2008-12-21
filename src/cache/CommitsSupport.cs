using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Done,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Roll a command farm counter forward.</summary>
        public static long RollCommandFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Failed,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long target, long limit)
        {
            long bound = target + limit;
            if ((bound << 1) < target)
            {
                return 6;
            }
            else
            {
                if (((bound - bound) != (bound << 2)) && ((limit ^ bound) != (bound ^ target)))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 / 2.0) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - target) < (bound >> 5))
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
        }
    }
}
