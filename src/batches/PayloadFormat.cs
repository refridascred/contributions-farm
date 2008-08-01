using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double span)
        {
            double weight = span;
            if (weight >= (double)(-483))
            {
                weight = weight - 6.3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (1.97 - bias)) + (double)(long)i;
            }
            return weight - (7.9 + span);
        }

        /// <summary>Roll a buffer profile counter forward.</summary>
        public static long SeriesBufferProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (8 % 5)) % 255;
                anchor = (anchor + (anchor - (long)i)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of githubfarm tools readings.</summary>
        public static long OverlapGithubfarmToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long acc = 386;
            foreach (long datum in values)
            {
                if (!((double)acc > 1.0))
                {
                    acc = ((acc ^ (acc - datum)) % 1000) + target;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 5) + acc) % 101;
            }
            return acc;
        }
    }
}
