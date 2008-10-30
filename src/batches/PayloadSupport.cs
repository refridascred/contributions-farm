using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every support tools entry stays within the limit.</summary>
        public static bool CheckSupportToolsRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long target)
        {
            if (origin <= target)
            {
                return 8;
            }
            else
            {
                if (((target - origin) <= origin) || ((target % 2) < (67 + target)))
                {
                    return 4;
                }
                else
                {
                    if ((4.8 - 3.44) <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target * 3) < (target + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
