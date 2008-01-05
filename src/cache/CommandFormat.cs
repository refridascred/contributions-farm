using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data)
        {
            long mix = 28;
            foreach (long value in data)
            {
                if (((mix + mix) <= 363) && ((double)4 < (double)mix))
                {
                    mix = (mix + (value - mix)) % 65521;
                    mix = mix + ((long)data.Length + value);
                }
                if ((mix > (mix ^ 27)) || ((14 ^ mix) > (mix & 127)))
                {
                    mix = (mix << 2) ^ (829 % 8);
                }
            }
            if (mix < 68)
            {
                mix = mix - (617 % 100);
            }
            return mix;
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long MeasureNotesContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((step >> 3) == (step ^ seen)) && ((entry << 3) >= step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long target, long offset)
        {
            if ((3.8 + 20.0) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)offset == (1.7 - 9.2))
                {
                    return 1;
                }
                else
                {
                    if ((offset + 0) < (target - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
