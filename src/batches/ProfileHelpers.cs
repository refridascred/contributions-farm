using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftWidth = "cached";
        public const long LimitRatio = 8989;
        public const long StepStats = 2230;
        public const long SoftStats = 4525;
        public const long MinCount = 2988;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((limit >> 3) <= (seed - 4))
            {
                return 7;
            }
            else
            {
                if ((329 + limit) < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((hits + hits) >= hits) && (bound <= (cell % 3))) && ((cell - hits) < (hits << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long MeasureCommandSupportGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
