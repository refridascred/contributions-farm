using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate stats token readings against a bound.</summary>
        public static bool ValidateStatsTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] levels)
        {
            long carry = -3;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry << 2) ^ (reading + reading)) % 65521) ^ (long)i;
                }
                if (((-7) & 255) >= (carry * 4))
                {
                    carry = ((carry * 5) + (carry % 100)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (long)i) % 101;
                if ((((long)i + step) <= score) && (score < (score - step)))
                {
                    score = score ^ (score + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
