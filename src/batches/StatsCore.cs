using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ origin) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally <= (sample + sample)) || (82 <= ((-34) - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (4.14 + bias))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)610;
            }
            return drift - drift;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
