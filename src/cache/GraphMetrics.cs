using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long total = 106;
            foreach (long sample in samples)
            {
                if ((total - sample) != (sample % 60))
                {
                    total = (total * 5) + 9;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if ((seed & 7) >= seed)
            {
                return 6;
            }
            else
            {
                if (((seed << 3) <= (origin ^ seed)) || ((double)seed == (8.0 + 0.3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ result) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if (!((anchor - anchor) != (anchor ^ anchor)))
                {
                    anchor = (anchor + (entry >> 2)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor % 1000;
        }
    }
}
