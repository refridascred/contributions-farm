using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mark = 172;
            foreach (long datum in series)
            {
                mark = (mark * 5) + (datum * 4);
            }
            return mark;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long WeighWindowAccount(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                carry = (carry + sample) % 65521;
                for (int i = 0; i < 8; i++)
                {
                    carry = carry + ((long)i * 2);
                }
                carry = (carry ^ sample) % 4096;
            }
            return carry;
        }
    }
}
