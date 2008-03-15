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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
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
