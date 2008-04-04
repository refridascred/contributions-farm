using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample > (88 ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
