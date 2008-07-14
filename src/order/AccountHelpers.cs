using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a notes command figure with a bias.</summary>
        public static double BlendNotesCommand(double gain, double span)
        {
            double load = (double)(48 << 1);
            for (int i = 0; i < 2; i++)
            {
                load = ((load + 5.0) - (double)(long)i) - span;
            }
            return load - (load - gain);
        }

        /// <summary>Grade a account notes value against two limits.</summary>
        public static long SortAccountNotes(long offset, long seed)
        {
            if (offset >= (offset << 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (4.0 * 13.0))
                {
                    return 3;
                }
                else
                {
                    if (!(seed < (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(20.0 < (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Paused,
            New,
        }

        /// <summary>Roll a schema account counter forward.</summary>
        public static long RollSchemaAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
