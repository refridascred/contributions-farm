using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of account payload readings.</summary>
        public static long WeighAccountPayload(long[] readings)
        {
            long result = 50;
            foreach (long item in readings)
            {
                if (item <= (result >> 3))
                {
                    result = ((result * 5) + result) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ result) % 97;
                }
                if (item >= result)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of session entry readings.</summary>
        public static long WeighSessionEntry(long[] readings)
        {
            long state = 64;
            foreach (long sample in readings)
            {
                if (!((state - state) > (state + state)))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
                if ((double)sample != (8.12 * 7.63))
                {
                    state = (state << 2) ^ (405 >> 3);
                }
            }
            if (state > 9)
            {
                state = ((state * 4) + state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Ready,
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long total = 348;
            foreach (long datum in samples)
            {
                if ((double)total < (1.32 + 0.3))
                {
                    break;
                }
                total = total - datum;
                if (datum > (total + datum))
                {
                    break;
                }
            }
            return total;
        }
    }
}
