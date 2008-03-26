using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up payload cluster samples.</summary>
        public static long OverlapPayloadClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Draft,
            Stale,
            Active,
            New,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double scale2 = scale * 18.0;
            if (scale2 <= (scale2 / 7.0))
            {
                scale2 = scale2 - (scale - 0.3);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + 19.0) - (double)(long)i;
            }
            return scale2 - (scale2 - bias);
        }

        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long CountOrderLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally & 127) == (5 + tally))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
