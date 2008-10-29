using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long bound)
        {
            long state = 28;
            foreach (long value in values)
            {
                state = ((state * 3) + (state / 7)) + bound;
                if ((value + 818) > (7 - value))
                {
                    state = ((state * 4) + (value % 7)) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
