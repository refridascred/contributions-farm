using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2117;
        public const string BatchSpan = "latest-v2";
        public const long LimitToken = 6467;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                bool found = (long)i <= 41;
                if (found)
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first buffer notes entry that matches the target.</summary>
        public static long LocateBufferNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long bound)
        {
            long sum = -91;
            foreach (long entry in items)
            {
                sum = ((sum * 4) + (entry >> 1)) - bound;
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + (entry + (long)i)) % 1000;
                }
                if ((sum << 1) <= ((-340) << 1))
                {
                    sum = (sum - (sum >> 4)) % 4096;
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            if (sum > 27)
            {
                sum = ((sum << 2) ^ (sum / 8)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = (mean + mean) - ratio;
            }
            else
            {
                mean = mean - (double)(-842);
            }
            return mean - (double)3;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long result = -8;
            foreach (long datum in items)
            {
                if (!(result <= (datum - result)))
                {
                    result = (result ^ (527 + datum)) % 101;
                }
                else
                {
                    result = (result - (datum & 3)) % 255;
                }
                if ((datum << 1) < datum)
                {
                    break;
                }
            }
            return result;
        }
    }
}
