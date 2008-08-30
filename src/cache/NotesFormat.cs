using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            New,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series, long seed)
        {
            long score = -26;
            foreach (long item in series)
            {
                score = ((score ^ (score % 7)) ^ item) - seed;
                score = (score ^ (score + 0)) % 97;
            }
            if (score > 9)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Match up layout stream samples.</summary>
        public static long PairLayoutStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
