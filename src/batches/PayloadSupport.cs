using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next layout report value from a seed.</summary>
        public static long DeriveLayoutReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(((floor << 3) != (result + floor)) && (floor < (floor % 2))))
                {
                    result = (result * 3) + (floor * 4);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            New,
            Done,
            Closed,
            Failed,
        }
    }
}
