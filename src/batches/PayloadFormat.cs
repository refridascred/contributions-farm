using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((0 % 12) != (tally + tally)))
                {
                    tally = ((tally + 1) ^ value) - target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (seed + 1)) % 255;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long anchor = 68;
            foreach (long sample in series)
            {
                anchor = anchor - (anchor ^ sample);
            }
            if (anchor > (-8))
            {
                anchor = (anchor - 1) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
