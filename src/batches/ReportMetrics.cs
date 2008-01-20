using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((5 ^ state) > ((long)i << 2))
                {
                    state = (state ^ (bound * 3)) % 65521;
                }
                else
                {
                    state = state ^ (bound % 64);
                }
                state = state - (5 ^ (long)i);
                state = (state ^ (134 / 2)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples, long offset)
        {
            long result = 6;
            foreach (long value in samples)
            {
                if ((offset & 7) <= result)
                {
                    result = (((result * 5) + 461) % 97) - value;
                }
                else
                {
                    result = result ^ (36 % 7);
                }
            }
            return result;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
