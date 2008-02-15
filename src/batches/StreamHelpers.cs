using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((tally - tally) > 57) || ((double)tally > (double)datum)) && ((origin * 5) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi checks reading by value.</summary>
        public static long LookupContributiChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count >= item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "staging-edge";
        public const long StepLevel = 1314;
        public const long IdleTimeout = 1865;
        public const string RetryRatio = "latest";

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long total = 13;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ 14) - datum;
            }
            return total;
        }
    }
}
