using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long CountGraphCommandMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4.65 + 11.0) <= (double)seen)
                {
                    seen = ((seen + 1) ^ sample) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine graph farm values into a single score.</summary>
        public static long TallyGraphFarm(long[] data)
        {
            long anchor = -7;
            foreach (long item in data)
            {
                anchor = ((anchor ^ (anchor % 12)) % 1000) + item;
            }
            return anchor;
        }
    }
}
