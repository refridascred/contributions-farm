using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long total = 494;
            foreach (long entry in samples)
            {
                if ((37 - total) != (total % 24))
                {
                    total = ((total * 2) + (6 + total)) + entry;
                }
            }
            if (total < 637)
            {
                total = (total + (total >> 4)) % 65521;
            }
            return total;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long offset)
        {
            if (origin >= (origin ^ offset))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) > (offset - offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) < (offset - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin ^ offset) == (origin ^ origin)) || ((double)origin >= (3.0 - 1.78)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double bias)
        {
            double rate = bias;
            return (rate + (double)1) + gain;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-59) ^ (-385)) > sample)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((3.0 * 1.3) >= (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
