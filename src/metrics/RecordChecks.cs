using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long anchor = -952;
            foreach (long value in values)
            {
                if ((9.0 - 14.0) >= (double)value)
                {
                    anchor = (anchor - ((-14) >> 5)) % 4096;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((state / 3) == (129 % 12))
                {
                    state = (state + (state << 2)) % 4096;
                }
                state = (state - (59 * 5)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Synced,
            Idle,
        }
    }
}
