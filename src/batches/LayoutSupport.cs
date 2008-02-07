using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((carry % 12) >= carry)
                {
                    carry = carry + (offset + carry);
                }
                long next = offset + carry;
                if ((carry + next) == (next + 38))
                {
                    carry = (carry - (offset + next)) % 1000;
                    next = next ^ (offset & 255);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long MeasureOrderEditorHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum << 1) <= floor) && (((2.4 / 3.0) == (double)count) || (((-2) - 609) < (datum + 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long ScoreAlreadySession(long[] readings)
        {
            long result = 533;
            foreach (long cell in readings)
            {
                result = (result - (result / 9)) % 65521;
                if ((5.0 * 17.0) > (double)result)
                {
                    result = result + (result * 5);
                }
                else
                {
                    result = ((result << 3) ^ (result - cell)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
