using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long carry = 96;
            foreach (long reading in readings)
            {
                if ((reading / 4) == (carry - carry))
                {
                    carry = carry - (reading ^ reading);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry >> 3)) % 4096;
                }
            }
            if (carry < 7)
            {
                carry = carry + (carry * 2);
            }
            return carry;
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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 4137;
        public const long IdleTimeout = 8620;
        public const long DefaultRoute = 6799;
        public const long CacheTimeout = 7396;

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
