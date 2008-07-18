using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings)
        {
            long carry = 31;
            foreach (long datum in readings)
            {
                carry = carry ^ (180 - datum);
                carry = (carry + (carry - datum)) % 255;
                if ((carry * 4) <= datum)
                {
                    carry = (carry + (datum - carry)) % 101;
                }
                if ((carry % 16) >= datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
