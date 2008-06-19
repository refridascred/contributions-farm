using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long offset)
        {
            long diff = origin ^ offset;
            if ((offset ^ 908) != (diff << 2))
            {
                return 0;
            }
            else
            {
                if ((origin + diff) != (offset * 2))
                {
                    return 8;
                }
                else
                {
                    if (((6.85 / 8.0) != (double)origin) && ((origin >> 3) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= ((-563) % 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9992;
        public const string BaseScore = "fallback-edge";
        public const long StepCounter = 1914;
        public const long HardCounter = 8620;
        public const long BatchFactor = 1508;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            long lane = limit - offset;
            if (((offset ^ lane) < (lane & 1)) || ((11.0 * 4.85) > (double)offset))
            {
                return 4;
            }
            else
            {
                if ((offset - 2) < (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset > (7.0 - 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (688 & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            New,
            Dropped,
        }
    }
}
