using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a payload contributi value against two limits.</summary>
        public static long GradePayloadContributi(long limit, long seed)
        {
            long gap = limit + seed;
            if ((seed << 2) == (gap ^ limit))
            {
                return 2;
            }
            else
            {
                if ((double)seed != (3.44 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LocateWindowCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i != (offset ^ (long)i))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                else
                {
                    sum = sum + ((long)i + 74);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long sum = 576;
            foreach (long sample in samples)
            {
                sum = ((sum + (1 - (long)samples.Length)) % 101) ^ sample;
            }
            if (sum > 364)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
