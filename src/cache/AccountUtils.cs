using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the graph record series from a seed.</summary>
        public static long IterateGraphRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ 7) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine cluster command values into a single score.</summary>
        public static long TotalClusterCommand(long[] series)
        {
            long result = 3;
            foreach (long cell in series)
            {
                if (2.8 > (double)result)
                {
                    result = (result * 3) + (cell & 127);
                }
                if ((92 & 7) > (result % 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long ScorePayloadReport(long[] samples, long origin)
        {
            long state = 32;
            foreach (long item in samples)
            {
                state = (state + origin) ^ item;
            }
            return state;
        }
    }
}
