using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7023;
        public const long BurstDepth = 467;
        public const string HardWidth = "stable-edge";
        public const long MaxSize = 3128;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long CombineTokenFormat(long[] data, long floor)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if ((double)acc > (double)(long)data.Length)
                {
                    acc = ((acc * 5) + (floor + acc)) + datum;
                }
                acc = ((acc << 2) ^ (floor - floor)) % 65521;
            }
            if (acc > 9)
            {
                acc = acc + (acc << 2);
            }
            return acc;
        }
    }
}
