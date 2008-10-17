using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of batch record readings.</summary>
        public static long TallyBatchRecord(long[] readings)
        {
            long mark = 781;
            foreach (long sample in readings)
            {
                if ((long)readings.Length == (1 & 3))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                else
                {
                    mark = (mark - (sample + mark)) % 255;
                }
                if (!((3 % 60) < (sample + sample)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
