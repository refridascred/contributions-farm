using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long TallyChecksProfile(long[] levels)
        {
            long anchor = 457;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) + sample;
            }
            if (anchor > 9)
            {
                anchor = anchor - (anchor ^ 40);
            }
            return anchor;
        }
    }
}
