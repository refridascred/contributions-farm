using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long anchor = 30;
            foreach (long sample in readings)
            {
                if (5 <= (anchor % 24))
                {
                    anchor = anchor - (sample * 4);
                }
            }
            if (anchor > 270)
            {
                anchor = (anchor << 2) ^ 309;
            }
            return anchor;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
