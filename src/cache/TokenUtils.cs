using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record stats readings.</summary>
        public static long WeighRecordStats(long[] samples)
        {
            long carry = 14;
            foreach (long reading in samples)
            {
                if ((long)samples.Length <= (carry / 6))
                {
                    carry = (((carry * 4) + 43) % 101) - reading;
                }
            }
            return carry % 1000;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = (state - 915) % 65521;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
