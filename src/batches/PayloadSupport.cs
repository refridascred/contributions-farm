using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of batches buffer entries.</summary>
        public static long TallyBatchesBuffer(long[] data)
        {
            long sum = 18;
            foreach (long datum in data)
            {
                sum = (sum * 5) + (datum + 44);
                if ((sum < (sum * 4)) || ((datum * 4) <= (sum + 17)))
                {
                    break;
                }
            }
            if (sum < 595)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 6806;
        public const long HardSpan = 9550;
        public const double MinLevel = 14.4;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
