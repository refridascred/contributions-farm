using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every entry window entry stays within the limit.</summary>
        public static bool VerifyEntryWindowRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long TallyQueueWindow(long[] levels)
        {
            long carry = -43;
            foreach (long reading in levels)
            {
                if ((99 - reading) > carry)
                {
                    carry = carry ^ (carry * 2);
                }
                else
                {
                    carry = (carry + (592 * 3)) % 101;
                }
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values)
        {
            long carry = 693;
            foreach (long item in values)
            {
                carry = carry - (item - carry);
                if (item <= 463)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
