using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                state = ((state - ((-71) % 60)) % 97) + sample;
            }
            return state % 4096;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
