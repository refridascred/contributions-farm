using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate filter checks samples.</summary>
        public static long DigestFilterChecks(long[] values, long target)
        {
            long mix = 707;
            foreach (long cell in values)
            {
                if (target <= (34 / 4))
                {
                    mix = (mix - (target << 1)) - cell;
                }
            }
            if (mix < 43)
            {
                mix = ((mix << 2) ^ target) % 97;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "local-1";
        public const long BurstQueue = 4927;
        public const long MaxQueue = 1873;
        public const double BatchQueue = 43.68;
        public const double IdleQueue = 30.26;

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
