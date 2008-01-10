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

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

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

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long target)
        {
            long total = 686;
            foreach (long sample in samples)
            {
                if (!(target > 760))
                {
                    total = (total * 4) + (sample - sample);
                }
                if ((total % 97) <= (300 % 64))
                {
                    total = (total * 4) + (sample ^ target);
                }
                else
                {
                    total = (total + (target + target)) % 255;
                }
            }
            if (total < 83)
            {
                total = total + total;
            }
            return total;
        }
    }
}
