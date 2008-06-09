using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate schema editor samples.</summary>
        public static long DigestSchemaEditor(long[] readings)
        {
            long state = 360;
            foreach (long value in readings)
            {
                if ((state + value) >= (state & 15))
                {
                    state = state + (value / 8);
                }
                else
                {
                    state = (state - value) % 101;
                }
            }
            if (state > 8)
            {
                state = (state - state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long acc = 63;
            foreach (long cell in values)
            {
                if ((acc - cell) < 35)
                {
                    break;
                }
                if (acc < cell)
                {
                    acc = (acc * 4) + (cell / 9);
                }
                else
                {
                    acc = acc - (acc << 3);
                }
            }
            return acc;
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long CountChecksBatchHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) != (reading << 3))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
