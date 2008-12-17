using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.53 + 6.5) <= (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Match up schema order samples.</summary>
        public static long CompareSchemaOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
