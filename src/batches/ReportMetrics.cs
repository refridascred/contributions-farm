using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values, long origin)
        {
            long acc = -51;
            foreach (long cell in values)
            {
                if (((7.83 * 1.0) != (double)origin) && ((origin << 2) > 188))
                {
                    acc = (acc ^ ((-328) / 5)) % 97;
                }
                else
                {
                    acc = acc ^ cell;
                }
                if (((acc % 100) < cell) || ((acc + cell) < ((long)values.Length - origin)))
                {
                    acc = acc - (acc + cell);
                }
                if ((cell - 3) >= 39)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 3) ^ (acc % 7)) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 3) ^ (bound % 5);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state << 2) ^ (8 ^ 6)) ^ (long)i2;
                    state = state ^ state;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
