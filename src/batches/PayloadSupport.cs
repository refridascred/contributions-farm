using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state * 2) + offset) ^ (long)i2;
                }
                if (!((offset ^ offset) != (long)i))
                {
                    state = ((state * 4) + ((long)i + offset)) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long CountContributiBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)count < 3.66) && ((3.5 * 4.41) != (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Locked,
            Queued,
        }
    }
}
