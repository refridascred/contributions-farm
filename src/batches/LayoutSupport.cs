using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Pending,
            Done,
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long total = -60;
            foreach (long value in items)
            {
                total = total - (value * 3);
            }
            return total % 97;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Paused,
            Pending,
            New,
            Done,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)origin > (9.0 - 9.57))
                {
                    continue;
                }
                else
                {
                    state = state ^ (state & 7);
                    state = ((state * 4) + (1 - 3)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a record already reading.</summary>
        public static double ScaleRecordAlready(double rate, double offset)
        {
            double load = (double)(80 * 3);
            return (load + (offset / 6.0)) + rate;
        }
    }
}
