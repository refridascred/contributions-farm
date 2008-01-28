using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Done,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long seed, long step)
        {
            if (((17.0 - 1.01) < (double)seed) || ((15.0 + 7.01) == (double)step))
            {
                return 7;
            }
            else
            {
                if ((32 ^ step) < step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
