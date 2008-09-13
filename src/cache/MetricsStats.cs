using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Stale,
            New,
            Active,
        }

        /// <summary>Fold a list of filter stream readings.</summary>
        public static long TallyFilterStream(long[] readings)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                if ((mix + 94) > (datum + mix))
                {
                    mix = (mix + (650 - mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long SeekClusterCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch schema readings against a rule.</summary>
        public static long TallyBatchSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((251 % 10) > (item + 104))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long target)
        {
            long gap = limit + target;
            if ((gap << 3) > (859 << 2))
            {
                return 8;
            }
            else
            {
                if ((42 - limit) == (gap + target))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ 928) != (gap / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
