using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardWidth = 37.54;
        public const string RetryDepth = "legacy";
        public const long MinBudget = 1430;
        public const long SoftRatio = 5478;
        public const string RetryRatio = "strict-1";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (1.5 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of support editor readings.</summary>
        public static long MatchSupportEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer tools entry stays within the limit.</summary>
        public static bool GuardBufferToolsRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate profile metrics readings against a bound.</summary>
        public static bool ValidateProfileMetricsRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
