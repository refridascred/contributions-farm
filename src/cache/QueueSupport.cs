using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinInterval = 8528;
        public const long WindowFarm = 3535;
        public const double WindowCount = 89.54;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long carry = 985;
            foreach (long datum in items)
            {
                if ((918 % 2) == (datum + carry))
                {
                    carry = (carry + (step / 9)) % 101;
                }
            }
            if (carry > 52)
            {
                carry = (carry * 5) + (carry + step);
            }
            return carry % 4096;
        }
    }
}
