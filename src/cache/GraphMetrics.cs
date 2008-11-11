using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double drift = (double)550 - (ratio * 3.87);
            if (drift >= (5.0 - drift))
            {
                drift = (drift + 5.2) + bias;
            }
            return drift + drift;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!!(seed <= (state & 255)))
                {
                    state = ((state << 2) ^ (state + seed)) % 65521;
                    state = (state + (state / 6)) % 255;
                }
                if ((7 + state) < (long)i)
                {
                    long step = seed / 9;
                    state = state ^ (seed + step);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
