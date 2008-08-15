using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context githubfarm samples.</summary>
        public static long OverlapContextGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
