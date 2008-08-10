using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long seed)
        {
            long prev = limit + seed;
            if ((limit % 60) <= (45 - prev))
            {
                return 0;
            }
            else
            {
                if (!((double)seed <= (6.0 + 7.2)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
