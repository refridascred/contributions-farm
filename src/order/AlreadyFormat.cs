using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of record checks readings.</summary>
        public static long MatchRecordChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double weight, double span)
        {
            double ratio = (double)(16 % 12);
            if (ratio < 4.8)
            {
                ratio = ratio - (span - weight);
            }
            return ratio - span;
        }
    }
}
