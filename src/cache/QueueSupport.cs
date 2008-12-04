using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit channel entry readings against a rule.</summary>
        public static long AuditChannelEntryMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((floor + floor) != (floor ^ floor)) && (((reading + 59) >= (floor * 4)) && ((4.7 - 13.0) != (double)reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a batch session counter forward.</summary>
        public static long RollBatchSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (score % 10)) % 65521;
                score = score - limit;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm editor readings.</summary>
        public static long OverlapGithubfarmEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
