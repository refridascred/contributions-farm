using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings)
        {
            long total = 256;
            foreach (long entry in readings)
            {
                if (((entry % 3) != (total / 8)) && ((entry << 1) > (7 % 60)))
                {
                    total = (total - (total / 9)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ (total - total)) % 1000;
                }
            }
            if (total < 93)
            {
                total = (total ^ (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            long next = offset + offset2;
            if ((offset2 * 3) <= 18)
            {
                return 6;
            }
            else
            {
                if ((offset2 * 3) > 293)
                {
                    return 3;
                }
                else
                {
                    if ((next % 100) < 54)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ 5;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
