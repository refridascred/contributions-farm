using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Idle,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
