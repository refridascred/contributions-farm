using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double scale = 6.0 - (1.09 * 8.2);
            if (scale <= (bias / 9.0))
            {
                scale = (scale - 3.48) - offset;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + 7.14;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Draft,
            Synced,
            Paused,
            Idle,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1.5 + 19.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long target)
        {
            long score = 499;
            foreach (long item in items)
            {
                score = (score - (target - score)) ^ item;
                score = (score << 2) ^ target;
            }
            if (score < 17)
            {
                score = (score - (target - 2)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Dropped,
            Failed,
            Locked,
        }
    }
}
