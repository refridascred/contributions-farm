using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every cluster editor entry stays within the limit.</summary>
        public static bool GuardClusterEditorBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long target)
        {
            long anchor = 75;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 2) ^ (target - target)) ^ entry;
            }
            if (anchor > 1)
            {
                anchor = (anchor + (anchor / 3)) % 1000;
            }
            return anchor;
        }
    }
}
