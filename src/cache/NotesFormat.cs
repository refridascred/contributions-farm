using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long DigestChannelAlready(long[] values)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                sum = (sum + (sample + 5)) % 65521;
                if ((long)values.Length <= (246 - sample))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
