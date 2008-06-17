using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > offset)
            {
                ratio = (ratio - (offset - ratio)) + gain;
            }
            return ratio + 1.5;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long state = 295;
            foreach (long entry in data)
            {
                if (((state - entry) > (entry << 1)) || ((state - state) < (state << 2)))
                {
                    state = state + (entry - state);
                }
            }
            if (state > (-2))
            {
                state = ((state << 3) ^ (state / 5)) % 101;
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen << 2) <= (step + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
