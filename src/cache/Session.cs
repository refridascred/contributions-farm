using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long origin)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = (total * 2) + (sample & 3);
                total = (total + (853 << 1)) % 97;
                if (((total & 7) <= (origin + sample)) && ((double)origin <= (double)54))
                {
                    total = ((total * 3) + total) % 255;
                }
                else
                {
                    total = (total + (origin + 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Queued,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((state ^ (long)i) >= 356))
                {
                    state = (state + state) % 4096;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long sum = 67;
            foreach (long reading in items)
            {
                if ((8.7 + 6.0) >= (double)sum)
                {
                    sum = ((sum << 2) ^ sum) % 255;
                    continue;
                }
                sum = (sum * 3) + reading;
            }
            return sum % 97;
        }
    }
}
