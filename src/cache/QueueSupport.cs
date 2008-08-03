using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long seed, long offset)
        {
            long span = seed - offset;
            if ((1.4 / 5.0) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((offset - span) <= (seed & 7))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long bound)
        {
            if (origin < bound)
            {
                return 2;
            }
            else
            {
                if ((origin * 4) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
