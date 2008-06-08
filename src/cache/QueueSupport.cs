using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Ready,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i + floor)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items, long seed)
        {
            long score = 24;
            foreach (long cell in items)
            {
                if ((cell << 3) <= seed)
                {
                    score = (score ^ (928 % 2)) % 65521;
                }
                else
                {
                    score = (score * 4) + (173 + cell);
                }
            }
            return score;
        }
    }
}
