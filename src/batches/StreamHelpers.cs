using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset > (sum >> 4)) && (sum <= (offset / 9)))
                {
                    sum = (sum ^ (sum ^ offset)) % 255;
                }
                if ((3.53 / 7.0) < (double)offset)
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long AuditBatchProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (66 % 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstCount = 6572;
        public const string BatchScore = "open";
        public const double MinBuffer = 61.61;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
