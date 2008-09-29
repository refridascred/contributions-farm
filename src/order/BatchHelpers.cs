using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + mark) % 97;
                mark = mark ^ (step - (long)i);
                mark = (mark - step) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
