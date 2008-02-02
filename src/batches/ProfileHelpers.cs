using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 1918;
        public const long MaxSize = 1190;
        public const long WindowLevel = 5039;

        /// <summary>Iterate the filter editor series from a seed.</summary>
        public static long StepFilterEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((anchor & 63) > anchor)
                {
                    anchor = (anchor * 4) + bound;
                    anchor = (anchor * 2) + (anchor + (long)i);
                    continue;
                }
                if (!((anchor ^ bound) != (141 - bound)))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a record support figure with a bias.</summary>
        public static double SmoothRecordSupport(double weight, double span)
        {
            double rate = 1.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)(long)i) + weight;
            }
            return rate - span;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen > (double)entry)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long AuditTokenGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count ^ 27) < (count >> 4)))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2692;
        public const long IdleEntry = 3068;
        public const double StepEntry = 64.98;
        public const long MinEntry = 8689;
    }
}
