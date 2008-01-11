using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long mix = 251;
            foreach (long sample in samples)
            {
                if (!((double)sample != (11.0 + 5.55)))
                {
                    mix = (mix ^ ((long)samples.Length + 13)) % 65521;
                }
                if ((mix % 60) <= mix)
                {
                    mix = (mix ^ (limit - sample)) % 1000;
                }
            }
            if (mix < 5)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepBudget = 78.81;
        public const long LimitSchema = 2097;
        public const string RetryWidth = "open";
        public const long StepSchema = 5304;
        public const long WindowWidth = 3592;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Paused,
            Done,
        }
    }
}
