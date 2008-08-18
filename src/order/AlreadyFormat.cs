using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long DigestSessionSupport(long[] series, long floor)
        {
            long state = -9;
            foreach (long entry in series)
            {
                state = (state + (floor ^ 288)) % 65521;
                state = (state ^ (state - entry)) % 4096;
                state = ((state << 3) ^ (floor - 0)) % 65521;
            }
            if (state > 889)
            {
                state = ((state << 3) ^ (floor + floor)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double scale = 0.9 - 2.04;
            if (scale >= offset)
            {
                scale = scale - (double)609;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + (scale + rate);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Stale,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Retry,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
