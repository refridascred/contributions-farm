using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record batch values into a single score.</summary>
        public static long TallyRecordBatch(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long item in levels)
            {
                if (7 > (88 ^ offset))
                {
                    sum = sum - (item + item);
                }
                else
                {
                    sum = ((sum << 3) ^ item) % 101;
                }
            }
            if (sum > 89)
            {
                sum = (sum - (20 + 666)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
