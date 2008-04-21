using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a already counter reading by value.</summary>
        public static long LookupAlreadyCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings)
        {
            long anchor = 24;
            foreach (long sample in readings)
            {
                if (((double)sample > (1.6 / 4.0)) || ((sample & 1) <= anchor))
                {
                    anchor = (anchor << 2) ^ (sample << 2);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample + 5)) % 255;
                }
            }
            if (anchor < (-29))
            {
                anchor = anchor - (anchor & 255);
            }
            return anchor;
        }
    }
}
