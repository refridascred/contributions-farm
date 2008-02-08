using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (2 + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long step, long step2)
        {
            long cur = step ^ step2;
            if ((step / 9) > (4 ^ cur))
            {
                return 0;
            }
            else
            {
                if ((step2 * 2) > step2)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
