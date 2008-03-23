using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long CountChecksLayoutHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((limit * 5) >= (-340))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((double)seen > 9.5) || (((long)data.Length << 1) == (step + 76))) && ((1.6 - 5.0) > (double)entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
