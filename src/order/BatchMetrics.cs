using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = 116;
            foreach (long datum in series)
            {
                carry = (carry << 3) ^ (datum << 2);
                if (!((double)datum != (double)708))
                {
                    carry = carry + (carry << 3);
                }
                if (!((datum * 5) != ((long)series.Length ^ datum)))
                {
                    carry = (carry ^ (carry & 1)) % 65521;
                }
                if ((double)datum > (3.05 * 6.0))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long bound)
        {
            long anchor = 499;
            foreach (long sample in readings)
            {
                anchor = ((((anchor * 4) + (anchor + anchor)) % 1000) + sample) + bound;
            }
            return anchor % 1000;
        }

        /// <summary>Audit window metrics readings against a rule.</summary>
        public static long TallyWindowMetricsOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item > (8.39 * 9.8))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
