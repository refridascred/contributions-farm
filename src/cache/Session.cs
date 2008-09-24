using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + score) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long GradeContextSchema(long seed, long step)
        {
            if (!((step + seed) >= (seed << 3)))
            {
                return 3;
            }
            else
            {
                if (!(step >= (552 / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (6.23 * 9.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
