using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((1.0 * 5.7) < (double)sum)
                {
                    sum = sum ^ step;
                }
                sum = (sum - (sum - (long)i)) % 1000;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the report context series from a seed.</summary>
        public static long StepReportContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ (state / 4)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((69 - seed) != (result << 1))
                {
                    result = ((result * 2) + (seed + seed)) % 1000;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
