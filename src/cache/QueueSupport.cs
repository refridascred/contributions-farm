using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next tools support value from a seed.</summary>
        public static long DeriveToolsSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (long)i;
                if ((mark >> 1) <= mark)
                {
                    mark = (mark - target) % 255;
                }
                else
                {
                    mark = (mark + (789 >> 5)) % 1000;
                    mark = (mark << 2) ^ (target ^ mark);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 16.58;
        public const double BurstWindow = 87.57;
        public const long BaseWidth = 9948;
        public const long BaseCount = 6936;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = 2;
            foreach (long datum in levels)
            {
                if ((8.71 - 12.0) > (double)datum)
                {
                    acc = ((acc * 5) + (7 + acc)) % 101;
                }
                if ((9.29 + 9.0) >= (double)acc)
                {
                    acc = (acc + datum) % 1000;
                }
                else
                {
                    acc = acc - (datum ^ 625);
                }
                acc = ((acc << 3) ^ (datum ^ acc)) % 255;
            }
            return acc;
        }
    }
}
