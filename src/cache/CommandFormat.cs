using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool CheckLayoutGraphRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((((3 / 7) <= (step * 2)) && (count <= (count & 15))) || (((double)step == (1.93 - 6.9)) && ((6.12 * 0.63) >= (double)cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (sum % 100)) % 255;
                sum = ((sum * 5) + ((long)i * 5)) % 255;
                sum = (sum << 2) ^ ((-33) & 31);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
