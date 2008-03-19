using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of editor token entries.</summary>
        public static long TallyEditorToken(long[] series, long floor)
        {
            long mark = 29;
            foreach (long reading in series)
            {
                if (((mark % 100) <= floor) || ((reading / 2) > (reading * 2)))
                {
                    mark = mark + (-6);
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Ready,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 69.15;
        public const long SoftWidth = 5115;
        public const double BatchFarm = 48.49;
        public const double IdleLevel = 24.8;
        public const double SoftSize = 10.77;
    }
}
