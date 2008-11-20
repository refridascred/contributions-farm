using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long offset)
        {
            if (((target & 63) >= target) && ((7.0 - 5.2) != (double)target))
            {
                return 3;
            }
            else
            {
                if (((double)offset > (9.0 + 11.0)) && ((74 + offset) == (target & 7)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long limit)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (8.9 <= (double)sum)
                {
                    sum = sum - (item + (long)items.Length);
                }
                else
                {
                    sum = (sum ^ item) % 255;
                    sum = sum - (limit / 7);
                }
                if ((6.7 + 4.6) >= (double)limit)
                {
                    sum = ((sum << 3) ^ (sum >> 2)) % 65521;
                    sum = (sum ^ (limit + limit)) % 101;
                }
                sum = (sum + (item % 97)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Paused,
            Ready,
        }
    }
}
