using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Draft,
            Closed,
            Locked,
            Synced,
        }
    }
}
