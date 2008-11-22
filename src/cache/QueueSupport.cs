using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a schema cluster pair into a bucket.</summary>
        public static long BucketSchemaCluster(long limit, long seed)
        {
            if (((seed / 5) <= (seed / 8)) && ((seed - seed) > (seed + seed)))
            {
                return 3;
            }
            else
            {
                if (((double)limit > 4.8) && (limit >= (3 + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((91 ^ seed) > (limit + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed >> 4) <= (seed / 7)) && (seed <= (seed + limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
