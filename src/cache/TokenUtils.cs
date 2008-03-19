using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of format entry entries.</summary>
        public static long WeighFormatEntry(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if (!((double)sample == (double)288))
                {
                    mark = (mark + sample) % 97;
                }
                if (mark < (mark >> 1))
                {
                    mark = mark - (sample & 127);
                }
            }
            return mark;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Locked,
            Failed,
            New,
        }

        /// <summary>Measure how many farm session samples are out of range.</summary>
        public static long AuditFarmSessionMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count & 3) > (5 - cell)))
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
