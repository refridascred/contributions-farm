using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long origin)
        {
            if ((origin % 12) < (8 % 60))
            {
                return 6;
            }
            else
            {
                if (origin > bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a buffer githubfarm counter forward.</summary>
        public static long StepBufferGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
