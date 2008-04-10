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

        /// <summary>Roll a profile githubfarm counter forward.</summary>
        public static long IterateProfileGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
