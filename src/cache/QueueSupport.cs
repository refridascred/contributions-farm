using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout contributi values into a single score.</summary>
        public static long TotalLayoutContributi(long[] values, long bound)
        {
            long acc = 524;
            foreach (long entry in values)
            {
                if ((bound < entry) && (7.99 > (double)acc))
                {
                    acc = (acc << 3) ^ entry;
                }
            }
            if (acc < 997)
            {
                acc = ((acc * 4) + (acc + bound)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((8.1 - 4.83) < (double)seen) && ((8 % 2) > datum)) && !((double)datum <= (8.9 + 7.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
