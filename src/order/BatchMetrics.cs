using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (99 < (sample + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the filter stats entries that pass the check.</summary>
        public static long CountFilterStatsHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally & 255) > sample)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit session filter readings against a rule.</summary>
        public static long CountSessionFilterHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((102 << 3) >= (tally ^ 4)) || ((50 ^ item) < (item + 3))) || !((11 + tally) > (tally >> 4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
