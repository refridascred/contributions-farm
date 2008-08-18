using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)step > (0.4 * 2.35))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                if ((9 - anchor) < ((long)data.Length - anchor))
                {
                    anchor = anchor ^ (item >> 5);
                }
                else
                {
                    anchor = (anchor - (long)data.Length) % 65521;
                }
            }
            if (anchor > 37)
            {
                anchor = (anchor - ((-29) & 255)) % 1000;
            }
            return anchor;
        }
    }
}
