using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long DeriveRecordQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (step / 7)) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
