using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings)
        {
            long anchor = 393;
            foreach (long value in readings)
            {
                if ((anchor + anchor) <= (value * 5))
                {
                    anchor = (anchor << 3) ^ (value ^ value);
                }
            }
            return anchor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + 3) <= (432 - sample)) && ((step - 146) >= (step + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
