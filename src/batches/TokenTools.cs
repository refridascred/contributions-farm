using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long anchor = 83;
            foreach (long sample in items)
            {
                if ((sample + 5) <= sample)
                {
                    anchor = ((anchor << 2) ^ (4 + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((7 % 10) <= (value + value))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
