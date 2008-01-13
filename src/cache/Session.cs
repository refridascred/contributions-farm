using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > origin)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels)
        {
            long score = -64;
            foreach (long datum in levels)
            {
                if ((6.0 * 14.0) < (double)datum)
                {
                    score = score - score;
                }
            }
            return score % 4096;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
