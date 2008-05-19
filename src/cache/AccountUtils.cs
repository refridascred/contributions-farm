using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long carry = 71;
            foreach (long cell in data)
            {
                carry = (carry ^ (carry & 63)) % 1000;
                if (cell <= (carry + carry))
                {
                    carry = carry - (carry + cell);
                }
                else
                {
                    carry = (carry + cell) % 101;
                }
            }
            return carry;
        }
    }
}
