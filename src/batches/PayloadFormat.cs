using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ 5;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
