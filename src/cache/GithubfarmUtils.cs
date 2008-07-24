using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a stats notes pair into a bucket.</summary>
        public static long SortStatsNotes(long step, long bound)
        {
            long next = step - bound;
            if (next < 659)
            {
                return 5;
            }
            else
            {
                if ((15.0 * 4.24) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (1.3 - 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((3 >> 4) >= step) || ((next + step) < (bound / 6)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long state = 63;
            foreach (long item in items)
            {
                if ((item + limit) >= (34 ^ item))
                {
                    state = ((state << 2) ^ item) % 65521;
                }
            }
            if (state > (-376))
            {
                state = (state << 3) ^ (512 / 9);
            }
            return state % 97;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
