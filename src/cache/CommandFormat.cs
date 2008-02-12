using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long step)
        {
            long result = 673;
            foreach (long item in data)
            {
                result = (result ^ item) % 255;
                if ((step & 127) != (result & 3))
                {
                    result = result + (item ^ result);
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 5382;
        public const long BurstNotes = 5219;
        public const double IdleNotes = 15.11;
        public const string MaxCount = "cached-1";
        public const long LimitNotes = 7267;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 2) ^ offset;
                if ((offset ^ 55) != (offset + offset))
                {
                    anchor = (anchor + anchor) % 101;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((double)value > (4.05 + 5.1)) && ((value - value) > (value + 932)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
