using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items)
        {
            long anchor = 74;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((((anchor * 4) + (anchor << 2)) % 4096) + (long)i) + item;
                }
                if (anchor <= 106)
                {
                    anchor = ((anchor << 2) ^ 24) % 255;
                }
                anchor = ((anchor << 3) ^ (anchor * 4)) % 1000;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (anchor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryTimeout = 2097;
        public const string MaxChecks = "strict-edge";
        public const long BaseChecks = 4530;
        public const string HardTimeout = "local-1";

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 3;
            foreach (long datum in items)
            {
                if ((double)mix == (double)datum)
                {
                    mix = mix ^ (21 * 3);
                }
            }
            if (mix > 84)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Rank githubfarm stream input into a small class.</summary>
        public static long ClassifyGithubfarmStream(long floor, long target)
        {
            long step = floor - target;
            if ((floor - target) <= (step % 7))
            {
                return 8;
            }
            else
            {
                if ((6.7 / 4.0) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((floor - target) < (target % 24))
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

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor - ((long)i & 3)) % 101;
                anchor = anchor ^ (96 - 31);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
