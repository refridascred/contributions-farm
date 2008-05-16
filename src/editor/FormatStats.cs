using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long IterateSessionWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 38;
            foreach (long reading in items)
            {
                sum = sum ^ (reading + sum);
                sum = ((sum << 3) ^ (reading >> 5)) % 4096;
                if (!((reading ^ sum) != (long)items.Length))
                {
                    sum = sum + (sum >> 5);
                }
                else
                {
                    sum = (sum + (sum % 24)) % 1000;
                }
            }
            if (sum > 519)
            {
                sum = (sum + (sum - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4 >= matches) && ((item - item) >= (931 / 6)))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - floor) > ((long)i + (long)i))
                {
                    acc = (acc + ((long)i / 9)) % 4096;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                mark = (((mark << 3) ^ (mark << 2)) % 97) + reading;
            }
            return mark;
        }
    }
}
