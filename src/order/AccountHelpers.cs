using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ anchor) % 255;
                anchor = ((anchor << 3) ^ limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = score + score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload metrics readings.</summary>
        public static long DigestPayloadMetrics(long[] readings)
        {
            long carry = 47;
            foreach (long datum in readings)
            {
                carry = (carry - datum) % 255;
                if (!(carry >= (datum + datum)))
                {
                    carry = carry ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long score = 268;
            foreach (long sample in values)
            {
                if ((double)sample > (14.0 / 7.0))
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    score = (score * 4) + (8 + score);
                }
                if (((sample + sample) >= score) || (score < (score & 255)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long anchor = 2;
            foreach (long datum in data)
            {
                anchor = (anchor + (anchor ^ anchor)) - datum;
            }
            return anchor % 65521;
        }
    }
}
