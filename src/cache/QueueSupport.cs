using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (4.75 * 20.0))
                {
                    seen = ((seen + 3) - item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples)
        {
            long state = -67;
            foreach (long item in samples)
            {
                if (state <= (state + item))
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
