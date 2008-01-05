using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items)
        {
            long anchor = 599;
            foreach (long entry in items)
            {
                if (((-19) ^ entry) == (760 ^ anchor))
                {
                    anchor = (anchor * 5) + (anchor * 3);
                }
                else
                {
                    anchor = (anchor - (entry & 1)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix << 1)) % 97;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every stream githubfarm entry stays within the limit.</summary>
        public static bool CheckStreamGithubfarmRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
