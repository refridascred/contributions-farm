using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long StepFilterMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a tools context reading by value.</summary>
        public static long LocateToolsContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long target)
        {
            long carry = 12;
            foreach (long sample in values)
            {
                if ((double)carry != (17.0 + 8.0))
                {
                    carry = (carry ^ (target * 5)) + sample;
                }
                if ((16 + carry) > (carry - target))
                {
                    break;
                }
            }
            if (carry < 821)
            {
                carry = (carry - (long)values.Length) % 1000;
            }
            return carry % 65521;
        }
    }
}
