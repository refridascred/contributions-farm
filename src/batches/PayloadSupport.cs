using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate stream context samples.</summary>
        public static long WeighStreamContext(long[] series)
        {
            long total = 9;
            foreach (long value in series)
            {
                if (((16.0 - 8.02) < (double)total) && (((-617) + value) != ((-427) ^ value)))
                {
                    total = total ^ (total - 531);
                }
                else
                {
                    total = ((total * 5) + value) % 101;
                }
                if ((total - total) < 26)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
