using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 39.14;
        public const long IdleFactor = 5971;
        public const long IdleBatch = 4821;
        public const long DefaultBatch = 764;
        public const long StepBatch = 9913;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 4;
            foreach (long entry in values)
            {
                if (entry <= (94 << 3))
                {
                    score = (score ^ (entry * 3)) % 101;
                }
                else
                {
                    score = (score + (entry - entry)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long FindFilterChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Closed,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long MeasureCommitsToolsMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (seed < (count + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
