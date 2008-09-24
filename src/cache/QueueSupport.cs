using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 4) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings)
        {
            long carry = 737;
            foreach (long datum in readings)
            {
                if ((datum <= (carry % 97)) || ((datum - carry) > (30 - 829)))
                {
                    carry = (carry - (datum - datum)) % 65521;
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry % 3)) % 97;
                }
                if ((carry + datum) > (long)readings.Length)
                {
                    carry = ((carry * 4) + (datum + carry)) % 101;
                }
                if (carry < (5 * 2))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix ^ (792 + target)) % 1000) ^ (long)i2;
                    mix = mix ^ (target * 2);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
