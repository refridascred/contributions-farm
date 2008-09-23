using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen ^ seen) >= (seen & 3))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
