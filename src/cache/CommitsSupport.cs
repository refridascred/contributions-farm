using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if (origin >= (diff & 255))
            {
                return 0;
            }
            else
            {
                if (((diff % 10) >= (diff - diff)) && ((43 + diff) > (1 + origin)))
                {
                    return 8;
                }
                else
                {
                    if (((double)diff != (16.0 - 6.6)) || ((diff - origin) >= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
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
