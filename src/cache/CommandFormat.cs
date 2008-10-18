using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((seen - item) >= item) || ((item ^ seen) > (item + item))) && ((double)seen <= 12.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long anchor = 416;
            foreach (long sample in series)
            {
                if ((0.49 / 3.0) == (double)anchor)
                {
                    anchor = (anchor + (sample - sample)) % 1000;
                }
            }
            if (anchor > (-57))
            {
                anchor = (anchor - (anchor & 127)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Closed,
            Dropped,
            Queued,
        }
    }
}
