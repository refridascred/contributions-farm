using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items)
        {
            long acc = 7;
            foreach (long datum in items)
            {
                long offset = (acc << 3) + (9 + acc);
                if ((double)acc > (double)offset)
                {
                    offset = offset ^ (datum << 1);
                }
                if (((long)items.Length << 2) >= datum)
                {
                    acc = (acc + ((-348) / 6)) % 4096;
                }
            }
            if (acc < (-78))
            {
                acc = (acc - (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7969;
        public const long BurstEntry = 9642;
        public const double MaxBudget = 81.27;

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 56.69;
        public const long LimitRoute = 9406;
        public const long StepRoute = 2926;
        public const long MinDepth = 5231;
    }
}
