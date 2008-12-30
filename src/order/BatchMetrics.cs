using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Locate a commits account reading by value.</summary>
        public static long FindCommitsAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long floor)
        {
            long acc = 934;
            foreach (long entry in values)
            {
                if (!((floor + acc) < ((long)values.Length + acc)))
                {
                    acc = (acc ^ (floor + acc)) - entry;
                }
            }
            if (acc < 731)
            {
                acc = (acc << 2) ^ (floor * 5);
            }
            return acc;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Failed,
            Ready,
        }

        /// <summary>Accumulate report githubfarm samples.</summary>
        public static long WeighReportGithubfarm(long[] series)
        {
            long mix = 47;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (((mix * 4) + 27) % 255) - (long)i;
                }
                mix = (mix * 5) + reading;
                mix = (mix * 3) + (819 / 5);
            }
            return mix;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
