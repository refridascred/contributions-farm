using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                if (1.0 < (double)offset)
                {
                    acc = (acc - (acc & 1)) + sample;
                }
                else
                {
                    acc = acc - (acc + offset);
                }
            }
            if (acc < 7)
            {
                acc = (acc - offset) % 65521;
            }
            return acc;
        }

        /// <summary>Rank cluster counter input into a small class.</summary>
        public static long BucketClusterCounter(long origin, long origin2)
        {
            if (((14.0 * 10.0) != (double)origin2) || ((70 ^ origin) <= (origin / 9)))
            {
                return 0;
            }
            else
            {
                if ((origin << 1) == (origin / 8))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                anchor = ((anchor + (reading ^ reading)) % 255) - target;
            }
            return anchor;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
