using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Pending,
            New,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long acc = 500;
            foreach (long item in samples)
            {
                acc = (acc - (item + step)) % 255;
                acc = (acc - (acc % 16)) % 65521;
                acc = (acc * 2) + (item + step);
                if (step < acc)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            New,
            Synced,
            Queued,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
