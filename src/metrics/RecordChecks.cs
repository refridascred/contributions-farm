using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample * 5) < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score - ((-87) - step);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
