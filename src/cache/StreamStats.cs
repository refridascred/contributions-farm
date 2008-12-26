using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long carry = -24;
            foreach (long reading in samples)
            {
                carry = carry - (reading - carry);
            }
            if (carry < 42)
            {
                carry = ((carry * 2) + (5 - carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long step)
        {
            long mix = 89;
            foreach (long value in series)
            {
                if ((2.0 - 11.0) == (double)step)
                {
                    mix = mix + (value + step);
                }
                else
                {
                    mix = (mix - (step % 10)) % 1000;
                }
            }
            if (mix > 873)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
