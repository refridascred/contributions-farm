using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                if ((double)acc == (4.5 / 8.0))
                {
                    acc = (acc ^ (4 + 992)) ^ entry;
                }
            }
            if (acc > 1)
            {
                acc = (acc << 3) ^ (69 + offset);
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples, long seed)
        {
            long total = 0;
            foreach (long entry in samples)
            {
                if (((entry >> 5) >= (total + 314)) || (((-1) ^ seed) <= entry))
                {
                    total = total - ((-421) - total);
                }
            }
            return total;
        }
    }
}
