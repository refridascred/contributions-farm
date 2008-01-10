using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) == ((long)levels.Length ^ datum))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 8530;
        public const long StepWidth = 6469;
        public const double LimitDepth = 12.66;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a window command counter forward.</summary>
        public static long StepWindowCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long MeasureTokenCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.1 > (double)count) || (count >= (reading - reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
