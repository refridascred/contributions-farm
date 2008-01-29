using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long anchor = 703;
            foreach (long cell in readings)
            {
                if (anchor >= (anchor % 24))
                {
                    anchor = (anchor + cell) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
