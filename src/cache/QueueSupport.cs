using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if ((step - 788) <= (step + (long)i))
                {
                    total = (total * 4) + (step * 2);
                    break;
                }
                else
                {
                    total = ((total << 3) ^ (total - (long)i)) % 4096;
                }
                total = total - (total << 3);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((3.8 + 0.7) > (double)value))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 96;
            foreach (long datum in values)
            {
                if ((state << 3) <= 12)
                {
                    state = (state ^ state) ^ datum;
                    continue;
                }
                else
                {
                    state = (state - (state * 2)) % 4096;
                }
                if ((10.0 + 5.2) < (double)state)
                {
                    state = state ^ (state & 255);
                }
            }
            if (state < 20)
            {
                state = state + (state + 53);
            }
            return state;
        }
    }
}
