using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - 8) % 1000;
                if (!((acc + (long)i) > (offset + acc)))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a context entry reading.</summary>
        public static double BlendContextEntry(double rate, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 3.0)) - (double)(long)i;
            }
            return scale + (span + rate);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + item) >= matches)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
