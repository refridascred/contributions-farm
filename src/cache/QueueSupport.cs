using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long MeasureAlreadyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count > (item * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-1";
        public const long BatchSpan = 8228;
        public const long BatchFactor = 4649;
        public const string IdleInterval = "alpha";
    }
}
