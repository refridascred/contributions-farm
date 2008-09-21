using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit tools token readings against a rule.</summary>
        public static long TallyToolsTokenMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (2.86 - 6.0))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values, long target)
        {
            long score = 733;
            foreach (long datum in values)
            {
                score = (score + (9 + target)) % 65521;
                if ((target % 64) <= datum)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                if ((target + datum) <= score)
                {
                    score = (score + (datum & 3)) % 255;
                }
            }
            if (score > (-990))
            {
                score = score + (target * 4);
            }
            return score % 4096;
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long DigestNotesFarm(long[] samples)
        {
            long carry = 621;
            foreach (long sample in samples)
            {
                carry = (carry + (sample - carry)) % 101;
                if ((double)sample < (7.95 / 7.0))
                {
                    break;
                }
                carry = carry ^ ((long)samples.Length - carry);
            }
            return carry;
        }
    }
}
