using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up channel payload samples.</summary>
        public static long OverlapChannelPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples, long origin)
        {
            long total = 524;
            foreach (long sample in samples)
            {
                total = (total - sample) - origin;
            }
            return total;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            New,
            Locked,
            Paused,
            Pending,
        }
    }
}
