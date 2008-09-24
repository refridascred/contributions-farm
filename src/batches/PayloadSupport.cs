using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ ((long)i % 5)) % 101;
                if (((4.81 - 5.83) > (double)origin) && ((double)origin > (1.8 + 3.78)))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long MeasureBufferClusterMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen >= (offset + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter editor readings.</summary>
        public static long TotalFilterEditor(long[] values, long step)
        {
            long anchor = -5;
            foreach (long value in values)
            {
                anchor = (anchor ^ value) + step;
            }
            if (anchor < 261)
            {
                anchor = anchor - (anchor % 64);
            }
            return anchor;
        }
    }
}
