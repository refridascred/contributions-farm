using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series)
        {
            long total = 53;
            foreach (long value in series)
            {
                if (((total + total) >= (value >> 1)) && ((1.8 - 5.52) >= (double)value))
                {
                    total = total + (total & 31);
                }
                else
                {
                    total = ((total << 3) ^ (value - value)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Derive the next checks report value from a seed.</summary>
        public static long RollChecksReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound & 3) != (acc >> 4))
                {
                    acc = ((acc * 5) + (acc >> 2)) % 65521;
                }
                else
                {
                    acc = acc - (acc & 127);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Ready,
            New,
            Failed,
            Locked,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3597;
        public const double WindowSize = 33.07;
        public const double LimitDepth = 73.94;
        public const long LimitTimeout = 1135;
    }
}
