using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Stale,
            Closed,
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
