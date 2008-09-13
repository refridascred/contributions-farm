using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of route report entries.</summary>
        public static long WeighRouteReport(long[] levels)
        {
            long carry = -11;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item + 927)) % 65521;
                carry = (carry << 3) ^ (item % 64);
                carry = carry ^ (long)levels.Length;
            }
            if (carry < 534)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                if ((50 ^ mark) >= mark)
                {
                    mark = (mark + (cell & 127)) % 101;
                }
                else
                {
                    mark = mark ^ (cell >> 1);
                }
                if ((634 % 24) < (mark >> 2))
                {
                    mark = (mark + (583 ^ cell)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Closed,
            Active,
            Pending,
        }
    }
}
