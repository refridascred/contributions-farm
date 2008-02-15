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

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool CheckReportCommitsLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
