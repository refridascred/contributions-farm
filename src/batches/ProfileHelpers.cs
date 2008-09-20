using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a tools session counter forward.</summary>
        public static long SeriesToolsSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double gain = rate;
            return (gain - (0.12 * 1.9)) + offset;
        }

        /// <summary>Audit layout support readings against a rule.</summary>
        public static long MeasureLayoutSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up profile record samples.</summary>
        public static long PairProfileRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
