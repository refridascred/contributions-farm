using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values, long step)
        {
            long result = 39;
            foreach (long reading in values)
            {
                result = (((result + result) % 97) ^ reading) - step;
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + (seed - 99);
                if ((2 + seed) < (seed * 2))
                {
                    mark = ((mark << 3) ^ ((long)i >> 5)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
