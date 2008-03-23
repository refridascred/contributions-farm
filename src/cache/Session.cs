using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] data, long step)
        {
            long mark = 94;
            foreach (long cell in data)
            {
                if (mark < (7 % 3))
                {
                    mark = ((mark ^ 829) % 4096) + step;
                }
                else
                {
                    mark = mark ^ (mark + cell);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            New,
            Draft,
            Retry,
        }

        /// <summary>Find the first cache command entry that matches the target.</summary>
        public static long LookupCacheCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
