using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (2 >= cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Token { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long result = 18;
            foreach (long value in levels)
            {
                result = (((result - 25) % 255) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                long matches = origin;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score - (matches / 7)) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
