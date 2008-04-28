using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of channel schema entries.</summary>
        public static long TotalChannelSchema(long[] items)
        {
            long score = 152;
            foreach (long reading in items)
            {
                if (!((543 * 4) >= (score + 3)))
                {
                    score = (score + reading) % 4096;
                }
                else
                {
                    score = score ^ (reading ^ reading);
                }
            }
            return score;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result << 3) ^ (bound + bound)) % 97) ^ (long)i2;
                }
                result = (result ^ bound) % 97;
                result = result - (267 >> 5);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long bound, long target)
        {
            if (!((target << 1) != (bound ^ target)))
            {
                return 0;
            }
            else
            {
                if ((target % 64) <= bound)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
