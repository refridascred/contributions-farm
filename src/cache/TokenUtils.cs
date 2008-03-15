using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long result = 94;
            foreach (long reading in series)
            {
                result = (result + (reading - result)) % 65521;
                if (result <= (4 - (-1)))
                {
                    result = ((result * 4) + result) % 97;
                }
                else
                {
                    result = ((result << 2) ^ 9) % 101;
                }
                if (((result % 3) >= (result + 32)) && ((reading * 4) >= (reading ^ result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
