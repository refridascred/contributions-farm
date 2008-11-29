using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long offset)
        {
            if ((double)offset != (5.26 + 9.5))
            {
                return 7;
            }
            else
            {
                if (!((offset ^ target) == (target + target)))
                {
                    return 6;
                }
                else
                {
                    if ((target + offset) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset > 4)
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

        /// <summary>Validate queue schema readings against a bound.</summary>
        public static bool CheckQueueSchemaLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Ready,
            Done,
        }
    }
}
