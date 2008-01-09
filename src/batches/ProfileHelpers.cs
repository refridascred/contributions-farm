using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter support samples.</summary>
        public static long CompareFilterSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many payload githubfarm samples are out of range.</summary>
        public static long TallyPayloadGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry + entry) >= (entry / 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload command counter forward.</summary>
        public static long DerivePayloadCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ ((long)i << 3)) % 4096) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Draft,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
