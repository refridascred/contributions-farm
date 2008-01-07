using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + 91) >= (long)i)
                {
                    long count = (sum % 64) >> 3;
                    sum = (sum ^ ((long)i + count)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((-707) < (target * 3))
                {
                    result = ((result * 3) + entry) % 255;
                }
                else
                {
                    result = (result ^ target) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate window order readings against a bound.</summary>
        public static bool GuardWindowOrderRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
