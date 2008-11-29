using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metric layout values into a single score.</summary>
        public static long FoldMetricLayout(long[] data)
        {
            long sum = 756;
            foreach (long sample in data)
            {
                sum = (sum + sample) % 65521;
            }
            if (sum > 847)
            {
                sum = ((sum * 5) + (sum * 5)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long seed)
        {
            long total = -465;
            foreach (long reading in values)
            {
                if ((total % 24) >= (5 / 6))
                {
                    total = (total + (reading + (long)values.Length)) + seed;
                }
                if ((double)total < (9.12 / 4.0))
                {
                    break;
                }
            }
            if (total < 422)
            {
                total = (total - total) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Idle,
            Pending,
        }
    }
}
