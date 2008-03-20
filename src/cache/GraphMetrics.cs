using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Stale,
            Synced,
            Active,
        }

        /// <summary>Count window command pairs that satisfy a relation.</summary>
        public static long PairWindowCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double mean = 5.0 / 8.0;
            if (mean > (weight * 4.33))
            {
                mean = (mean - (13.0 + 5.11)) - offset;
            }
            else
            {
                mean = mean + (double)443;
            }
            return mean - 8.6;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long acc = 58;
            foreach (long reading in values)
            {
                if (acc > (acc % 3))
                {
                    acc = ((acc - (567 / 2)) % 101) + reading;
                }
                else
                {
                    acc = (acc ^ (acc % 8)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((0.1 / 3.0) >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
