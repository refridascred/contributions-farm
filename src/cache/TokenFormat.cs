using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a command profile counter forward.</summary>
        public static long StepCommandProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (target + 9)) % 255;
                if ((long)i <= target)
                {
                    mark = mark + (target >> 5);
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = result - (28 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
