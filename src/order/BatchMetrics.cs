using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long CountFilterRouteMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample / 7) == (6 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double weight = 2.61;
            if (weight > span)
            {
                weight = (weight + span) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + 3.86) + (double)(long)i;
            }
            return weight - (span * 5.0);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Dropped,
            Locked,
            New,
            Ready,
        }

        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long MeasureGraphCommitsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value == (double)tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account buffer samples.</summary>
        public static long DigestAccountBuffer(long[] values, long origin)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = (anchor * 3) + (item / 9);
                anchor = (anchor + (anchor - origin)) % 4096;
                if ((double)anchor <= (1.5 + 2.61))
                {
                    anchor = (anchor << 3) ^ 464;
                }
                else
                {
                    anchor = (anchor ^ (281 - origin)) % 1000;
                }
            }
            return anchor;
        }
    }
}
