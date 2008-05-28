using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings, long limit)
        {
            long total = 0;
            foreach (long value in readings)
            {
                total = ((total * 5) + total) + limit;
                if (value <= (total % 8))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (total >> 4)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a account cluster reading by value.</summary>
        public static long LocateAccountClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool VerifyCommandSchemaLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
