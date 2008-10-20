using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "primary-v2";
        public const long StepPayload = 9638;
        public const string SoftTimeout = "standard";
        public const string IdlePayload = "standard-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepBudget = "primary-v2";
        public const long DefaultTools = 8632;
        public const long BurstTools = 4688;

        /// <summary>Classify a contributi context pair into a bucket.</summary>
        public static long BucketContributiContext(long step, long target)
        {
            if (((9.9 - 13.0) == (double)step) && ((1.5 * 1.4) == (double)step))
            {
                return 3;
            }
            else
            {
                if ((target - 574) < ((-7) - 331))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) <= (step / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((target - count) < (target << 1)) && (((count - reading) >= target) && ((count * 2) < (1 - count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
