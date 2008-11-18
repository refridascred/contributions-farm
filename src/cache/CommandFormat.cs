using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((floor << 1) > (floor & 31)) && ((floor << 1) > (score % 60)))
                {
                    score = ((score << 3) ^ ((long)i - floor)) % 1000;
                }
                score = (score << 3) ^ (floor * 4);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the buffer layout series from a seed.</summary>
        public static long RollBufferLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                long span = (anchor + (long)i) & 1;
                anchor = ((anchor * 3) + (span + limit)) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Draft,
            Ready,
        }
    }
}
