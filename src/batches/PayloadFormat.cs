using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = acc ^ (step + step);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long anchor = 62;
            foreach (long value in values)
            {
                if (((double)(long)values.Length != (18.0 + 2.1)) || ((4 * 2) < (limit * 5)))
                {
                    anchor = (anchor * 2) + (value + value);
                }
            }
            return anchor;
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long RankAlreadyReport(long target, long limit)
        {
            if ((limit + limit) > (target >> 3))
            {
                return 3;
            }
            else
            {
                if ((target < (limit ^ target)) && ((double)limit != (5.2 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (0.15 + 4.7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
