using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings, long floor)
        {
            long anchor = 48;
            foreach (long value in readings)
            {
                anchor = (((anchor * 4) + 162) - value) - floor;
            }
            return anchor;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstInterval = "primary";
        public const double SoftGraph = 27.09;
        public const long LimitScore = 1361;

        /// <summary>Fold a list of commits editor readings.</summary>
        public static long TallyCommitsEditor(long[] items, long origin)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                if (!((origin * 3) >= (anchor + anchor)))
                {
                    anchor = (anchor + (anchor >> 1)) - entry;
                }
                anchor = anchor + ((-499) + 6);
            }
            if (anchor > 325)
            {
                anchor = ((anchor * 3) + anchor) % 255;
            }
            return anchor;
        }
    }
}
