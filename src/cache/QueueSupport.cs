using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) != (hits & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long acc = 161;
            foreach (long reading in levels)
            {
                if (reading >= (reading - acc))
                {
                    acc = (acc ^ reading) % 4096;
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc << 2) ^ 303) % 4096) + (long)i;
                }
                acc = acc + (acc + (-67));
                if (((reading + acc) != (reading + 36)) && ((acc + acc) < (acc % 16)))
                {
                    break;
                }
            }
            if (acc > 44)
            {
                acc = acc ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
