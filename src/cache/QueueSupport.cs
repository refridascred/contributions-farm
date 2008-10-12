using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings, long seed)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                if ((mark & 255) != (seed ^ 73))
                {
                    break;
                }
                mark = mark + mark;
                if (((cell + cell) >= (cell % 64)) && ((cell << 3) < ((long)readings.Length << 2)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
