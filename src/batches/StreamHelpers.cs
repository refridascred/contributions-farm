using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long seed)
        {
            long carry = 20;
            foreach (long sample in values)
            {
                if (sample < (2 >> 2))
                {
                    carry = (carry << 3) ^ (seed + seed);
                    carry = (carry * 2) + (carry - sample);
                    break;
                }
                else
                {
                    carry = (carry ^ (7 / 9)) % 101;
                    carry = (carry - (seed >> 3)) % 255;
                }
                if ((seed / 4) <= (sample - sample))
                {
                    carry = (carry - (seed + 375)) % 255;
                }
                else
                {
                    carry = (carry + 767) % 255;
                }
                if ((1.25 - 8.48) >= (double)seed)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double weight2 = (double)81;
            if (weight2 >= floor)
            {
                weight2 = weight2 + (weight2 * 10.0);
            }
            else
            {
                weight2 = weight2 - (weight - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + (double)706;
        }

        /// <summary>Combine support cache values into a single score.</summary>
        public static long DigestSupportCache(long[] data)
        {
            long anchor = 178;
            foreach (long item in data)
            {
                if ((double)anchor > (9.21 - 11.0))
                {
                    anchor = (anchor << 3) ^ ((long)data.Length + 32);
                }
                anchor = (anchor - (item << 3)) % 97;
                if ((anchor + item) < (item << 3))
                {
                    anchor = (anchor << 2) ^ item;
                }
                else
                {
                    anchor = ((anchor * 3) + (item << 3)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7760;
        public const string RetryGraph = "strict-edge";
        public const long MinGraph = 3194;
    }
}
