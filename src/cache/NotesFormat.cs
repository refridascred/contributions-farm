using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double span)
        {
            double drift = span;
            if (drift <= 2.0)
            {
                drift = (drift - (span / 6.0)) - bias;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (span - span);
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 5) + (long)i;
                double scale = (double)(result << 1);
                if (((6.65 - scale) != (8.11 - scale)) || ((offset ^ (long)i) < (offset - result)))
                {
                    result = result ^ ((long)i % 8);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
