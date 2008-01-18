using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((126 + 9) <= (seen - seen)) || ((seen << 1) >= (datum / 7)))
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

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Dropped,
            Active,
            Draft,
            Closed,
        }
    }
}
