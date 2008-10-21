using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a support already pair into a bucket.</summary>
        public static long ClassifySupportAlready(long origin, long step)
        {
            if (step > (step + origin))
            {
                return 3;
            }
            else
            {
                if (!((double)origin >= (13.0 + 1.3)))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin > 20.0) && ((1.93 + 5.0) > (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((step + step) <= (origin / 6)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Queued,
            Done,
            Synced,
        }
    }
}
