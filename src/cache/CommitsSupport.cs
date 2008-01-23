using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen - item))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            if ((1.31 * 4.13) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (11.0 - 5.05))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed == (3.52 - 6.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3396;
        public const double StepFactor = 58.73;
        public const long SoftCounter = 5957;
        public const long DefaultCounter = 3374;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((2.4 / 6.0) == (double)target))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
