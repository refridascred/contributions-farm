using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score << 3) ^ (step + 514);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Ready,
            Idle,
            Done,
            New,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) < (seen + reading))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
