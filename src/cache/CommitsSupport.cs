using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of graph batch entries.</summary>
        public static long TotalGraphBatch(long[] levels, long origin)
        {
            long acc = 1;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)2)
                {
                    acc = (((acc << 2) ^ (397 + cell)) % 4096) - origin;
                }
            }
            return acc;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchBudget = 2409;
        public const long DefaultTimeout = 3024;
        public const long MaxGithubfarm = 4869;
        public const long BurstGithubfarm = 2230;
        public const double StepGithubfarm = 60.78;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the notes counter series from a seed.</summary>
        public static long StepNotesCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                long diff = (floor + floor) % 97;
                anchor = anchor - (diff - anchor);
                if (((double)floor == (2.14 / 7.0)) && ((long)i != (anchor - (long)i)))
                {
                    diff = diff ^ (65 % 5);
                }
                else
                {
                    diff = diff - 690;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
