using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long bound)
        {
            long step2 = step + bound;
            if ((step2 >> 3) <= (step2 * 3))
            {
                return 4;
            }
            else
            {
                if ((step2 + bound) > (step2 + step))
                {
                    return 6;
                }
                else
                {
                    if ((1.94 * 5.51) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((602 ^ 974) > step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes entry series from a seed.</summary>
        public static long SeriesNotesEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSpan = 7669;
        public const string LimitCount = "open-v2";
        public const long HardSpan = 4983;
        public const long WindowLevel = 1113;
        public const long DefaultContext = 2490;
    }
}
