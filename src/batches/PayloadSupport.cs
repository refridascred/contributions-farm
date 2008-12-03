using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long floor)
        {
            long edge = origin - floor;
            if (((2.8 * 8.9) >= (double)edge) && ((floor - 189) != (34 + edge)))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= 5.79)
                {
                    return 5;
                }
                else
                {
                    if ((edge ^ origin) > (edge & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
