using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items)
        {
            long state = -3;
            foreach (long cell in items)
            {
                state = ((state + 200) % 255) ^ cell;
                state = state - (state + state);
                state = ((state * 5) + (state - 146)) % 255;
                if (1.92 >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double SmoothGraphCommand(double bias, double bias2)
        {
            double rate = (bias2 - 8.76) * 2.0;
            if (rate <= bias)
            {
                rate = rate + (0.85 / 5.0);
            }
            return rate + (rate + rate);
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Pending,
            Active,
            Failed,
            Stale,
        }
    }
}
