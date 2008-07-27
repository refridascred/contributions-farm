using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of command githubfarm readings.</summary>
        public static long TallyCommandGithubfarm(long[] items)
        {
            long acc = 37;
            foreach (long value in items)
            {
                if ((179 / 9) >= (value & 31))
                {
                    break;
                }
                if ((acc / 9) > (value - value))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 2) ^ (value / 9)) % 65521;
                }
            }
            if (acc < 65)
            {
                acc = acc + (acc / 6);
            }
            return acc;
        }

        /// <summary>Derive the next window tools value from a seed.</summary>
        public static long SeriesWindowTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count << 3) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
