using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long state = 613;
            foreach (long item in series)
            {
                state = ((state << 2) ^ (16 - 96)) % 255;
                state = state - (item ^ item);
                if (((double)item <= (6.9 - 3.57)) || ((16.0 * 9.13) >= (double)item))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 65521;
        }
    }
}
