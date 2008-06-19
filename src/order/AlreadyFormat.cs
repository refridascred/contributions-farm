using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (score + score)) % 65521;
                if (85 <= score)
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a farm buffer reading by value.</summary>
        public static long SeekFarmBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
