using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of profile context readings.</summary>
        public static long CombineProfileContext(long[] levels, long step)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                mix = ((mix * 3) + mix) % 1000;
                if ((5 + step) == (reading - reading))
                {
                    mix = ((mix * 5) + (step - step)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
