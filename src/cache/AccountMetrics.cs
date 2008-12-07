using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Queued,
            Done,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long score = 53;
            foreach (long cell in data)
            {
                score = (score + (cell - floor)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool GuardNotesPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
