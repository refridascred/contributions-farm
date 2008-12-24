using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((7 % 2) < ((long)series.Length - datum)))
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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long offset)
        {
            long result = -1;
            foreach (long reading in samples)
            {
                result = ((result - (offset << 2)) % 1000) + reading;
            }
            if (result > 3)
            {
                result = (result ^ result) % 101;
            }
            return result % 97;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
