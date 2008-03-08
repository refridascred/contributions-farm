using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((seed - 944) < (982 >> 5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor contributi series from a seed.</summary>
        public static long SeriesEditorContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = acc - ((long)i & 31);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchDepth = 1204;
        public const string MinChecks = "latest-1";
        public const long StepChecks = 756;
        public const long BaseTimeout = 3928;
        public const long IdleScore = 3380;
    }
}
