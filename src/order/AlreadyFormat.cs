using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of counter report entries.</summary>
        public static long FoldCounterReport(long[] levels)
        {
            long total = 68;
            foreach (long datum in levels)
            {
                total = total ^ datum;
            }
            return total % 65521;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (limit ^ (long)i)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (result <= (result & 1))
                {
                    result = ((result * 2) + (result - result)) % 97;
                }
                else
                {
                    result = ((result * 2) + (31 * 4)) % 4096;
                    result = result - (6 + 0);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
