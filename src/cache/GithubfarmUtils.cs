using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long origin)
        {
            long anchor = -4;
            foreach (long item in values)
            {
                if (((double)item <= (3.0 + 0.7)) || ((373 ^ origin) > (400 + item)))
                {
                    anchor = anchor ^ (83 + origin);
                }
                else
                {
                    anchor = ((anchor * 4) + anchor) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long acc = -64;
            foreach (long item in samples)
            {
                if ((item + limit) != (acc - item))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
                else
                {
                    acc = acc + limit;
                }
            }
            if (acc > 551)
            {
                acc = (acc * 3) + (limit ^ acc);
            }
            return acc;
        }
    }
}
