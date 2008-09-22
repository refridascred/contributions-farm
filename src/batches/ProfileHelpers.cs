using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 1342;
        public const long RetryStats = 7150;
        public const string MaxInterval = "latest";
        public const long MaxStats = 58;
        public const double IdleStats = 74.39;

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double BlendNotesContext(double weight, double span)
        {
            double scale = span;
            if (scale < (double)57)
            {
                scale = scale + (span + weight);
            }
            else
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 1994;
        public const long MinBudget = 9424;
        public const string MinDepth = "primary-1";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset <= (offset + anchor)) || ((long)i != (anchor / 9)))
                {
                    anchor = ((anchor << 3) ^ 0) % 101;
                    anchor = anchor ^ (8 + anchor);
                }
                if (!(anchor <= offset))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
