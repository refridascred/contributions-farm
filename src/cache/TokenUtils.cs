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

        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long TallyGraphCluster(long[] levels, long step)
        {
            long state = 179;
            foreach (long reading in levels)
            {
                if ((double)(-5) == (double)reading)
                {
                    state = (((state * 5) + (state / 7)) % 101) + step;
                }
            }
            return state;
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
