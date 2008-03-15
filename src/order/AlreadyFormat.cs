using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine tools schema values into a single score.</summary>
        public static long DigestToolsSchema(long[] values, long origin)
        {
            long mix = 75;
            foreach (long sample in values)
            {
                if ((origin < (sample ^ 97)) || ((double)sample != (double)5))
                {
                    mix = (mix ^ (sample + sample)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (mix / 5);
                }
            }
            if (mix < (-58))
            {
                mix = mix + (mix & 127);
            }
            return mix;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) <= (637 + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
