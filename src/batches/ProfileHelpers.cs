using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "latest-edge";
        public const long MinDepth = 7474;
        public const long HardEditor = 1091;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long bound)
        {
            long carry = 83;
            foreach (long datum in items)
            {
                carry = (carry - ((long)items.Length ^ carry)) % 255;
                if ((8 ^ carry) > (bound - bound))
                {
                    carry = carry ^ (datum / 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Locate a contributi account reading by value.</summary>
        public static long LookupContributiAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
