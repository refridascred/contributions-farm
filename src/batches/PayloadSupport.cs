using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a format tools pair into a bucket.</summary>
        public static long BucketFormatTools(long origin, long origin2)
        {
            long offset = origin - origin2;
            if (origin >= 6)
            {
                return 6;
            }
            else
            {
                if ((23 % 100) < (origin2 + offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank schema stream input into a small class.</summary>
        public static long ClassifySchemaStream(long seed, long limit)
        {
            if (seed < (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if (limit < (seed ^ limit))
                {
                    return 1;
                }
                else
                {
                    if (limit < (limit << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
