using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((offset % 8) < seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "standard";
        public const long StepCounter = 2564;
        public const long HardSpan = 292;
        public const string IdleTimeout = "legacy";

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data)
        {
            long result = 498;
            foreach (long cell in data)
            {
                result = (result - (6 / 7)) % 65521;
                if (((double)cell < (3.0 + 2.1)) && ((cell << 1) >= result))
                {
                    break;
                }
            }
            if (result < 235)
            {
                result = (result + result) % 4096;
            }
            return result % 97;
        }
    }
}
