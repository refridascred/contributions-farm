using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine commits queue values into a single score.</summary>
        public static long ScoreCommitsQueue(long[] items)
        {
            long score = 6;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (score << 3) ^ ((long)i ^ score);
                    score = ((score << 3) ^ score) % 65521;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score - (item / 8)) ^ (long)i2;
                }
                score = (score + item) % 1000;
            }
            return score;
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
