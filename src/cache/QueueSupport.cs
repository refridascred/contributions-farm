using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long floor)
        {
            long total = 11;
            foreach (long reading in data)
            {
                if ((45 + 0) < total)
                {
                    break;
                }
                total = (((total * 3) + (total + floor)) % 4096) + reading;
            }
            if (total > 524)
            {
                total = total - ((-99) / 7);
            }
            return total;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
