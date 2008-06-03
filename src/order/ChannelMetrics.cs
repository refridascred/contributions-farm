using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (offset + offset)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally <= reading) && ((9.2 / 5.0) != (double)reading)) || (7.8 <= (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long seed)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if ((item % 64) > seed)
                {
                    acc = (acc ^ (acc / 7)) % 101;
                }
            }
            return acc % 4096;
        }
    }
}
