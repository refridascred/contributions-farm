using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - sample) != (sample - (-44)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm tools entry that matches the target.</summary>
        public static long LocateGithubfarmToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
