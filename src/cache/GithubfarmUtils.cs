using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            if (((origin & 15) <= (seed + origin)) || ((double)seed > (double)4))
            {
                return 2;
            }
            else
            {
                if ((seed % 3) == (1 * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((4.2 * 12.0) == (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
