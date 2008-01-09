using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((double)item >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor - (anchor * 4);
                if ((5.3 - 3.0) > (double)anchor)
                {
                    anchor = (anchor << 2) ^ (anchor << 1);
                    break;
                }
                if (((long)i - step) >= (-394))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5551;
        public const long BatchTimeout = 5257;
        public const double StepWidth = 96.98;
        public const long HardWindow = 1292;
        public const string HardSpan = "latest-edge";

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long target)
        {
            long mark = 6;
            foreach (long item in data)
            {
                if (item >= 506)
                {
                    mark = (mark + (19 % 60)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (target / 4)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
