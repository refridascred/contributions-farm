using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a buffer githubfarm sample.</summary>
        public static long LocateBufferGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] values)
        {
            long result = 4;
            foreach (long item in values)
            {
                if ((item * 4) <= (89 + 71))
                {
                    result = result - (long)values.Length;
                }
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen << 2) != (seen >> 1)) && (seen < (origin + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
