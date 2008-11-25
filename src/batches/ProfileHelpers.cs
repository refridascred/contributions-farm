using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-6) << 3) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long mix = 413;
            foreach (long reading in series)
            {
                if (((2.32 * 2.0) <= (double)reading) && ((step * 2) == (reading - reading)))
                {
                    mix = (mix + (step / 2)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
