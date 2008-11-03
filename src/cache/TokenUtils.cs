using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Stale,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long StepGithubfarmRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                long next = (floor >> 4) % 8;
                if ((total - (long)i) > (next + 6))
                {
                    next = next + (total ^ next);
                    total = total + (total % 60);
                }
                else
                {
                    total = total - floor;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
