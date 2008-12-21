using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((result & 1) < limit)
                {
                    break;
                }
                else
                {
                    result = (result - (long)i) % 101;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (seen % 10))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
