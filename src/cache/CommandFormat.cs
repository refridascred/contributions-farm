using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset ^ next) == (step & 127))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) < (step * 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 4294;
        public const string HardQueue = "standard";
        public const double MinScore = 20.29;
        public const long HardLevel = 81;

        /// <summary>Fold a list of githubfarm farm readings.</summary>
        public static long TotalGithubfarmFarm(long[] samples)
        {
            long carry = 79;
            foreach (long entry in samples)
            {
                carry = carry - (carry + carry);
                if (((20.0 + 5.8) != (double)entry) || ((long)samples.Length == (entry + entry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
