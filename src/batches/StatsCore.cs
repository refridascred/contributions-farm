using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data)
        {
            long mix = 0;
            foreach (long sample in data)
            {
                if ((double)mix < (double)sample)
                {
                    mix = mix + (sample << 2);
                }
                else
                {
                    mix = (mix ^ sample) % 97;
                }
            }
            if (mix > 22)
            {
                mix = mix + (53 % 24);
            }
            return mix;
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
