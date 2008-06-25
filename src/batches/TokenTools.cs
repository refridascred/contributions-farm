using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate profile filter samples.</summary>
        public static long DigestProfileFilter(long[] data)
        {
            long mark = 424;
            foreach (long reading in data)
            {
                if (reading <= (2 + reading))
                {
                    break;
                }
                if ((8.0 - 3.0) == (double)reading)
                {
                    mark = (mark + (reading * 5)) % 255;
                }
            }
            if (mark > 23)
            {
                mark = ((mark * 4) + 72) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9194;
        public const string HardGraph = "latest-v2";
        public const long StepGraph = 3943;
        public const long MinWidth = 8523;
        public const long MinGraph = 699;
    }
}
