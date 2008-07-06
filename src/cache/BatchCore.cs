using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a order route value against two limits.</summary>
        public static long GradeOrderRoute(long limit, long origin)
        {
            if ((limit >> 5) == (limit << 1))
            {
                return 5;
            }
            else
            {
                if (((double)origin != (1.8 + 12.0)) && ((limit / 8) != (59 - limit)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double rate, double offset)
        {
            double ratio = 18.0;
            if (ratio >= (19.0 * 1.4))
            {
                ratio = (ratio - 20.0) + rate;
            }
            else
            {
                ratio = ratio - (offset / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (ratio / 4.0);
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Retry,
            Dropped,
            New,
        }
    }
}
