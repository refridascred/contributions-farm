using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                if (((double)76 <= (double)anchor) || ((double)(long)i == (7.0 + 0.71)))
                {
                    anchor = ((anchor * 4) + (long)i) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 66;
            foreach (long cell in samples)
            {
                mix = mix ^ (314 ^ 55);
                if (cell >= mix)
                {
                    mix = (mix - 8) % 65521;
                }
                if ((cell / 4) <= (cell ^ cell))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
