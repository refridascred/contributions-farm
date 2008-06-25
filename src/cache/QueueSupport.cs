using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 798;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (result - datum))
                {
                    result = (result ^ result) % 4096;
                }
                if (((112 % 10) >= (result ^ datum)) && (result < (datum % 16)))
                {
                    result = result + ((long)levels.Length / 6);
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long bound)
        {
            long span = floor - bound;
            if (543 <= (bound + floor))
            {
                return 5;
            }
            else
            {
                if ((floor <= ((-9) / 9)) || ((span + bound) <= (32 << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((400 ^ floor) <= (span + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound >= (41 + bound))
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

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxSize = 4.07;
        public const string LimitLevel = "fallback-v2";
        public const double MinFarm = 17.9;
    }
}
