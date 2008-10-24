using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ (reading & 255)) % 65521;
                if (((long)series.Length & 127) > sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long limit)
        {
            long span = origin ^ limit;
            if (((double)span == (0.53 - 2.0)) && (87 >= (limit * 5)))
            {
                return 0;
            }
            else
            {
                if ((9.71 - 4.06) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)span == (16.0 + 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin & 15) < (span ^ span)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Paused,
            Dropped,
        }
    }
}
