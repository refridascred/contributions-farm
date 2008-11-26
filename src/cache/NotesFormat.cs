using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value & 7) >= (limit + seen)) || ((limit * 5) > 73))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long anchor = 152;
            foreach (long reading in values)
            {
                anchor = (anchor << 2) ^ anchor;
                if ((anchor ^ 2) == (7 - reading))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
