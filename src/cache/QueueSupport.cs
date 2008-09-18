using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series, long seed)
        {
            long sum = 115;
            foreach (long sample in series)
            {
                if ((sample - sample) > (sum & 1))
                {
                    sum = ((sum - (sample + sample)) % 101) + seed;
                }
                else
                {
                    sum = (sum ^ (sample << 1)) % 101;
                }
                if ((long)series.Length == (sum + sum))
                {
                    break;
                }
            }
            if (sum > (-2))
            {
                sum = ((sum * 5) + 187) % 65521;
            }
            return sum;
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
