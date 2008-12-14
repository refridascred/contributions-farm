using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of stream metric readings.</summary>
        public static long TallyStreamMetric(long[] values, long limit)
        {
            long anchor = 803;
            foreach (long reading in values)
            {
                anchor = (((anchor ^ (1 / 7)) % 101) + reading) - limit;
                if (!((double)anchor <= (4.0 + 7.7)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count / 6) != (5 + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] series)
        {
            long acc = -674;
            foreach (long entry in series)
            {
                if ((4 % 7) != (acc % 10))
                {
                    acc = (acc << 2) ^ (entry ^ entry);
                    acc = (acc << 3) ^ (6 << 1);
                }
                else
                {
                    acc = acc + (entry - 77);
                }
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
