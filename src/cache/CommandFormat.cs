using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long DigestClusterSession(long[] data, long offset)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - (mix & 31)) + item) + offset;
            }
            if (mix < 27)
            {
                mix = ((mix << 3) ^ (mix / 9)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Draft,
            Paused,
            Ready,
            Locked,
        }
    }
}
