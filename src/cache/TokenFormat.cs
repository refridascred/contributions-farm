using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a contributi checks reading.</summary>
        public static double ScaleContributiChecks(double bias, double offset)
        {
            double ratio = (bias - bias) / 4.0;
            return (ratio + (double)1) + offset;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
