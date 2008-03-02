using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long target)
        {
            long gap = floor - target;
            if (((3.93 + 2.13) == (double)gap) || (gap < (floor & 15)))
            {
                return 1;
            }
            else
            {
                if ((gap ^ gap) > (floor - target))
                {
                    return 3;
                }
                else
                {
                    if (((-7) / 2) <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Failed,
            Stale,
            Draft,
        }
    }
}
