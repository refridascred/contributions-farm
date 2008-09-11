using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a account queue sample.</summary>
        public static long LookupAccountQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double bias = (double)3 * 20.0;
            return (bias - (rate + 8.41)) + span;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits << 2) < value)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((936 - seen) >= seen))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long limit)
        {
            if ((limit % 60) < (target & 63))
            {
                return 6;
            }
            else
            {
                if ((8 >= (limit + 8)) || ((limit & 31) != (6 + limit)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
