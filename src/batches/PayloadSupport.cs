using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    long tally = origin;
                    state = (state * 4) + ((long)i2 - tally);
                }
                state = (state ^ ((long)i + origin)) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long target)
        {
            long result = 294;
            foreach (long entry in values)
            {
                if ((result + entry) <= result)
                {
                    result = (result + (30 + result)) % 4096;
                }
            }
            if (result < (-5))
            {
                result = (result << 2) ^ (target ^ (-8));
            }
            return result % 97;
        }
    }
}
