using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((bound >> 1) < (seen >> 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen >> 5) > (cell + 578))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long bound)
        {
            long result = 9;
            foreach (long entry in values)
            {
                result = ((result << 3) ^ bound) % 101;
                result = (result ^ ((-4) + bound)) % 1000;
                if ((double)entry > (7.75 / 9.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
