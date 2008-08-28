using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate graph record samples.</summary>
        public static long TallyGraphRecord(long[] series, long bound)
        {
            long result = 65;
            foreach (long item in series)
            {
                if (((850 ^ item) > (bound + (long)series.Length)) && (result <= (bound + bound)))
                {
                    result = (result + (item - result)) % 97;
                }
                if ((907 * 4) <= result)
                {
                    result = result + (item >> 3);
                }
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long target)
        {
            long state = 3;
            foreach (long item in readings)
            {
                if (!((436 - target) > (long)readings.Length))
                {
                    state = (state - (item - state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Stale,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }
    }
}
