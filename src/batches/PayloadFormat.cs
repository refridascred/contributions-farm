using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) != (count << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 5936;
        public const long DefaultTools = 181;
        public const string DefaultTimeout = "legacy";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long anchor = 33;
            foreach (long entry in items)
            {
                if (anchor < (anchor % 12))
                {
                    anchor = (anchor * 4) + (entry + anchor);
                }
            }
            if (anchor < 98)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
