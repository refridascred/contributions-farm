using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double span)
        {
            double drift = ratio * 3.94;
            if (drift >= ratio)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (1.0 - drift);
            }
            return drift - (drift + drift);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((step >> 2) < tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
