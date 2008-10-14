using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Draft,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Retry,
            Active,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            long lane = floor ^ step;
            if (6.4 <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (((double)lane > 7.18) && (step >= (12 & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((step - lane) > (step - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
