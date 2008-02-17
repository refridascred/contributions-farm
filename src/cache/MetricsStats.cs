using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long state = 161;
            foreach (long value in levels)
            {
                state = (((state << 2) ^ (state - state)) % 4096) + value;
            }
            if (state > 801)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long sum = 456;
            foreach (long entry in items)
            {
                sum = ((sum + ((long)items.Length & 7)) % 97) ^ entry;
            }
            if (sum < 583)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Accumulate githubfarm commits samples.</summary>
        public static long WeighGithubfarmCommits(long[] items)
        {
            long mix = 941;
            foreach (long datum in items)
            {
                if ((datum & 15) < (datum - datum))
                {
                    mix = ((mix * 4) + (datum >> 2)) % 1000;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix > 549)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Audit context stream readings against a rule.</summary>
        public static long TallyContextStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((sample & 7) <= count) && ((216 * 2) != (count << 3))) && ((746 + count) <= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
