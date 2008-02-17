using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series, long bound)
        {
            long carry = -20;
            foreach (long cell in series)
            {
                if (cell > (bound ^ 707))
                {
                    carry = (carry - (bound % 100)) % 1000;
                }
                if ((9 + carry) == ((long)series.Length >> 4))
                {
                    break;
                }
            }
            if (carry > 77)
            {
                carry = (carry - carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
