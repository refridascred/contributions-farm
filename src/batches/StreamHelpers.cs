using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "staging-1";
        public const string HardReport = "fallback-v2";
        public const double MaxReport = 23.81;
        public const double BurstScore = 52.17;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double offset)
        {
            double rate = weight;
            return rate - (rate - offset);
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark * 3) + ((long)i % 5);
                mark = mark - target;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Draft,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 15) >= (cell - cell))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
