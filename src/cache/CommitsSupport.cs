using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9213;
        public const double WindowTools = 24.21;
        public const long RetryDepth = 5209;
        public const string SoftDepth = "legacy-edge";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Measure how many checks contributi samples are out of range.</summary>
        public static long TallyChecksContributiMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count > (value + seed)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            long slot = offset - origin;
            if (slot > (slot * 2))
            {
                return 3;
            }
            else
            {
                if ((slot << 2) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= 11.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                if (offset < state)
                {
                    state = (state << 3) ^ (2 / 5);
                }
                else
                {
                    state = (state << 2) ^ (state + 69);
                }
                state = state + ((long)i + offset);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many cache notes samples are out of range.</summary>
        public static long TallyCacheNotesMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) == (target + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
