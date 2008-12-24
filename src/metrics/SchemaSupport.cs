using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Fold a list of booking readings.</summary>
        public static long FoldBooking(long[] series, long seed)
        {
            long mark = 22;
            foreach (long sample in series)
            {
                mark = (mark << 3) ^ (sample + seed);
            }
            return mark % 1000;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
