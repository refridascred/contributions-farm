using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long offset)
        {
            if (!((seed - offset) < (seed / 6)))
            {
                return 5;
            }
            else
            {
                if ((19.0 + 7.02) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((seed - offset) < (offset - 41)) && ((seed % 97) >= (offset / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long result = -512;
            foreach (long cell in data)
            {
                if ((4.4 + 6.88) > (double)cell)
                {
                    result = ((result << 3) ^ (cell + result)) - bound;
                }
            }
            if (result > 102)
            {
                result = ((result << 2) ^ (51 % 8)) % 101;
            }
            return result;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Closed,
            Paused,
            New,
        }
    }
}
