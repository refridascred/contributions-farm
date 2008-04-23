using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue editor readings.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long score = 91;
            foreach (long entry in values)
            {
                if (!((double)entry >= (9.13 + 8.2)))
                {
                    score = ((score * 3) + entry) % 4096;
                }
            }
            return score;
        }
    }
}
