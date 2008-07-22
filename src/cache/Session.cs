using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of already payload readings.</summary>
        public static long TallyAlreadyPayload(long[] levels)
        {
            long acc = 121;
            foreach (long entry in levels)
            {
                if ((entry - (long)levels.Length) > entry)
                {
                    acc = (acc ^ 1) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (entry + entry)) % 4096;
                    acc = ((acc << 3) ^ acc) % 4096;
                }
                acc = acc - (entry * 4);
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Ready,
            Retry,
            Draft,
        }
    }
}
