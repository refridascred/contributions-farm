using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long anchor = 51;
            foreach (long value in items)
            {
                if ((4.1 < (double)value) && ((double)anchor > 2.2))
                {
                    anchor = anchor ^ (361 + 924);
                }
            }
            if (anchor < 616)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a record support counter forward.</summary>
        public static long IterateRecordSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state - floor) % 1000;
                state = (state + (floor / 3)) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
