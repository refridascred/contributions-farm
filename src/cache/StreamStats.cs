using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long sum = 648;
            foreach (long datum in readings)
            {
                if ((double)datum > (8.41 - 16.0))
                {
                    sum = sum - (sum * 4);
                }
                if (sum >= (sum & 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine layout cache values into a single score.</summary>
        public static long ScoreLayoutCache(long[] values, long origin)
        {
            long score = 445;
            foreach (long cell in values)
            {
                score = (score ^ (score << 2)) + cell;
            }
            if (score > 89)
            {
                score = score ^ (origin + origin);
            }
            return score % 65521;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
