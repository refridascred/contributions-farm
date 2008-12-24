using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every filter farm entry stays within the limit.</summary>
        public static bool ValidateFilterFarmRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels, long step)
        {
            long sum = 95;
            foreach (long value in levels)
            {
                sum = (sum - sum) + value;
            }
            if (sum < 384)
            {
                sum = (sum ^ (333 + step)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
