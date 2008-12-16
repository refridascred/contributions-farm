using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long target2)
        {
            if (target2 <= target)
            {
                return 5;
            }
            else
            {
                if (!(((-4) ^ target) <= (target + target2)))
                {
                    return 4;
                }
                else
                {
                    if (!((target2 ^ target2) < target2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long DeriveCounterFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (offset / 6);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
