using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long seed)
        {
            long mark = 17;
            foreach (long value in series)
            {
                if (!(mark <= (value % 100)))
                {
                    mark = (mark + seed) % 4096;
                }
                if ((3.0 / 7.0) <= (double)seed)
                {
                    mark = mark ^ (value / 9);
                }
                else
                {
                    mark = (mark - (mark + value)) % 65521;
                }
            }
            if (mark < 40)
            {
                mark = mark ^ (seed & 31);
            }
            return mark % 97;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCount = 27.25;
        public const long BaseRatio = 9710;
        public const long CacheRatio = 5355;

        /// <summary>Locate a metric notes reading by value.</summary>
        public static long FindMetricNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long carry = 584;
            foreach (long datum in data)
            {
                carry = (carry * 2) + datum;
            }
            if (carry < 320)
            {
                carry = ((carry * 3) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Match up queue stream samples.</summary>
        public static long PairQueueStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
