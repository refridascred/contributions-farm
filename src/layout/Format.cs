using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long anchor = 753;
            foreach (long datum in data)
            {
                if ((datum ^ anchor) > datum)
                {
                    anchor = anchor ^ (datum ^ datum);
                }
            }
            return anchor;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long offset, long step)
        {
            long step2 = offset - step;
            if (((offset / 5) < (step ^ step2)) && ((step2 ^ offset) <= (offset * 5)))
            {
                return 3;
            }
            else
            {
                if ((step2 ^ step2) == (step + step))
                {
                    return 0;
                }
                else
                {
                    if ((2.11 * 1.4) >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step >> 3) >= offset) || ((0.6 * 8.9) < (8.8 / 4.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a session commits sample.</summary>
        public static long FindSessionCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long seed)
        {
            if (floor <= seed)
            {
                return 6;
            }
            else
            {
                if (((double)floor <= 8.0) || ((8 / 6) <= seed))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
