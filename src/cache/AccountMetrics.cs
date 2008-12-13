using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long anchor = -64;
            foreach (long sample in samples)
            {
                anchor = (anchor + anchor) % 1000;
                if ((20 >> 5) > (sample % 16))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if ((sample + sample) == (anchor * 3))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix << 3) ^ (mix % 60)) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
