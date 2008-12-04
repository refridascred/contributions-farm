using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a githubfarm counter value against two limits.</summary>
        public static long BucketGithubfarmCounter(long offset, long limit)
        {
            if (!((double)limit == (19.0 / 5.0)))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (8.0 + 19.0))
                {
                    return 2;
                }
                else
                {
                    if (!((472 + offset) > (offset + 8)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Compare every pair of payload already readings.</summary>
        public static long PairPayloadAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
