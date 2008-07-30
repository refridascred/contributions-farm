using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long acc = 56;
            foreach (long sample in values)
            {
                if ((16 + sample) < (sample ^ sample))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ (0 * 5);
                }
            }
            return acc;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = (result - result) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long TallyContributiSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((step + sample) == ((long)series.Length - 734))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
