using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark * 5) + (918 >> 4);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
