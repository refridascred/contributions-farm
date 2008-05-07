using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(limit < total))
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a counter filter pair into a bucket.</summary>
        public static long GradeCounterFilter(long target, long offset)
        {
            if (((offset + target) != (target >> 3)) && (target >= (7 * 4)))
            {
                return 3;
            }
            else
            {
                if ((12.0 >= (double)offset) && (2.0 < (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((2.0 / 3.0) < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
