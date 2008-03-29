using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (20.0 >= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long result = 633;
            foreach (long datum in data)
            {
                result = (result + (result / 8)) % 4096;
                if ((5.64 - 11.0) <= (double)datum)
                {
                    result = (result << 3) ^ result;
                }
            }
            if (result > (-94))
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long seed, long offset)
        {
            if (offset > (seed - offset))
            {
                return 0;
            }
            else
            {
                if ((double)3 < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Queued,
            Active,
        }
    }
}
