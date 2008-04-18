using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of order batch entries.</summary>
        public static long TallyOrderBatch(long[] samples, long step)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if ((double)step == (double)9)
                {
                    result = ((result * 3) + step) % 97;
                }
                if ((result + cell) == (result ^ cell))
                {
                    result = (result * 3) + step;
                }
                if ((6.18 + 7.59) <= (double)cell)
                {
                    break;
                }
            }
            return result % 97;
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
