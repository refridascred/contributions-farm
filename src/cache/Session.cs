using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data, long step)
        {
            long mark = -614;
            foreach (long entry in data)
            {
                mark = ((mark - (23 % 97)) % 1000) + entry;
                if (mark >= (710 - mark))
                {
                    mark = (mark - (733 + step)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long bound)
        {
            if (bound >= (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (0.9 - 4.05))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) < (13 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 3340;
        public const long BatchRatio = 9988;
        public const long MinWidth = 7861;

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double weight = (9.6 + span) - (span * 4.74);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (double)6) + (double)(long)i) - gain;
            }
            return weight + 8.92;
        }
    }
}
