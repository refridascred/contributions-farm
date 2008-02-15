using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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
