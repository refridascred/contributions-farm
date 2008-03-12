using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long origin)
        {
            long step = bound + origin;
            if ((origin << 1) < bound)
            {
                return 5;
            }
            else
            {
                if ((bound >> 5) < (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((step >> 1) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long limit)
        {
            long anchor = 8;
            foreach (long cell in values)
            {
                if ((limit << 1) > anchor)
                {
                    anchor = (anchor + anchor) % 65521;
                }
                else
                {
                    anchor = (anchor - (cell >> 2)) % 255;
                }
            }
            if (anchor < 440)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double rate = 5.8 - (weight + weight);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (weight * 3.62);
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = ((state * 4) + (bound * 4)) + (long)i3;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
