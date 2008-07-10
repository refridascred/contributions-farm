using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 10.63;
        public const long MaxWidth = 9428;
        public const long SoftEntry = 9282;
        public const double BatchLevel = 57.97;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (663 < (76 + count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
