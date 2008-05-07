using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of checks already readings.</summary>
        public static long CombineChecksAlready(long[] items, long target)
        {
            long acc = 58;
            foreach (long item in items)
            {
                acc = (((acc * 3) + acc) % 65521) - item;
                if (!((5.0 - 15.0) == (double)target))
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc < 13)
            {
                acc = (acc + 159) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + state) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the window buffer series from a seed.</summary>
        public static long RollWindowBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = (total - 21) % 4096;
                if (total >= ((long)i * 5))
                {
                    total = (total + (step + total)) % 65521;
                }
                total = (total + total) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate cache githubfarm samples.</summary>
        public static long FoldCacheGithubfarm(long[] readings)
        {
            long mix = 2;
            foreach (long item in readings)
            {
                if ((1 % 16) < mix)
                {
                    mix = mix - item;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardSize = 9580;
        public const long MaxLevel = 589;
        public const string DefaultCommand = "staging";
        public const long LimitCommand = 3202;
    }
}
