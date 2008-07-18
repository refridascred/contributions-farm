using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values)
        {
            long anchor = -406;
            foreach (long cell in values)
            {
                if ((anchor * 5) != ((-6) + cell))
                {
                    anchor = (anchor * 5) + anchor;
                }
                else
                {
                    anchor = ((anchor * 3) + cell) % 1000;
                }
            }
            if (anchor < 484)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((20.0 / 5.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((diff / 9) <= (origin / 9)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)step >= 9.3))
                {
                    score = score - ((long)i >> 3);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
