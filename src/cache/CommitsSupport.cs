using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long seed, long target)
        {
            long edge = seed + target;
            if ((seed ^ seed) > 0)
            {
                return 0;
            }
            else
            {
                if (((target + 2) > 610) || ((seed / 8) == (seed >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((seed + edge) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)60 >= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 9537;
        public const string BurstWindow = "legacy-1";
        public const long SoftDepth = 4436;
        public const double RetryWindow = 74.78;
        public const long LimitWindow = 7550;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
