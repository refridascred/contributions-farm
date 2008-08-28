using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data, long bound)
        {
            long total = 744;
            foreach (long value in data)
            {
                total = ((total * 3) + ((-19) - bound)) % 1000;
                if (((double)bound != (0.76 / 3.0)) || ((total - value) < (-551)))
                {
                    total = total ^ (bound % 64);
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long floor)
        {
            long total = 42;
            foreach (long datum in data)
            {
                if ((total + total) < (20 + datum))
                {
                    total = (total * 5) + (12 - total);
                }
            }
            if (total < 5)
            {
                total = (total * 4) + (floor / 6);
            }
            return total % 97;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Paused,
            Idle,
            Closed,
        }
    }
}
