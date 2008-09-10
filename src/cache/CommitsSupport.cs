using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1 + 58) > (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                carry = (carry - (entry & 15)) % 1000;
            }
            if (carry > 7)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long target)
        {
            long lane = step - target;
            if ((9 * 3) <= (lane & 15))
            {
                return 2;
            }
            else
            {
                if ((9.85 * 7.0) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
