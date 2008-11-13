using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "staging";
        public const long RetryQueue = 6768;
        public const double BatchQueue = 26.16;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long edge = step - offset;
            if ((5 >> 4) < (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if (!((double)edge <= (14.0 / 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                if ((mix ^ entry) > (mix / 2))
                {
                    mix = mix - ((long)series.Length + entry);
                }
            }
            return mix % 65521;
        }
    }
}
